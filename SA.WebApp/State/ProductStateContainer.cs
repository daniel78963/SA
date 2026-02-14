using Microsoft.AspNetCore.SignalR.Client;
using SA.Application.DTOs;
using SA.Application.Interfaces;
using Microsoft.AspNetCore.Components; // Para NavigationManager

namespace SA.WebApp.State
{
    public class ProductStateContainer
    {
        private readonly IProductService _productService;
        private readonly HubConnection _hubConnection;

        // El estado real (la lista de productos)
        public List<ProductDto> Products { get; private set; } = new();
        // Propiedad para saber si ya cargamos datos (opcional, para evitar recargas)
        public bool IsLoaded { get; private set; } = false;
        // Evento que se dispara cuando el estado cambia
        public event Action? OnChange;

        /// <summary>
        /// Inyectamos el servicio en el constructor
        /// </summary>
        /// <param name="productService"></param>
        public ProductStateContainer(IProductService productService, NavigationManager navigation)
        {
            _productService = productService;

            // 1. Configuramos la conexión al Hub
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(navigation.ToAbsoluteUri("/productHub"))
                .WithAutomaticReconnect()
                .Build();

            // 2. Definimos qué hacer cuando recibimos un mensaje del servidor
            _hubConnection.On<ProductDto, string>("ReceiveProductUpdate", (product, changeType) =>
            {
                HandleRealTimeUpdate(product, changeType);
            });

            // 3. Iniciamos la conexión (Fire and forget o async en inicialización)
            _ = StartConnectionAsync();
        }

        private async Task StartConnectionAsync()
        {
            try { await _hubConnection.StartAsync(); }
            catch { /* Manejar error de conexión */ }
        }

        // Lógica para actualizar la lista local sin ir a la BD
        private void HandleRealTimeUpdate(ProductDto product, string changeType)
        {
            if (!IsLoaded) return; // Si no hemos cargado, la próxima carga traerá lo nuevo

            switch (changeType)
            {
                case "Create":
                    Products.Add(product);
                    break;
                case "Update":
                    var index = Products.FindIndex(p => p.Id == product.Id);
                    if (index != -1) Products[index] = product;
                    break;
                case "Delete":
                    Products.RemoveAll(p => p.Id == product.Id);
                    break;
            }
            NotifyStateChanged(); // ¡Esto actualiza la UI de Ventas mágicamente!
        }

        /// <summary>
        /// Método para cargar datos desde la BD (Solo si no están cargados)
        /// </summary>
        /// <returns></returns>
        public async Task EnsureInitializedAsync()
        {
            if (!IsLoaded)
            {
                var productsFromDb = await _productService.GetProductsAsync();
                Products = productsFromDb.ToList();
                IsLoaded = true;
                NotifyStateChanged();
            }
        }

        // Método para establecer el valor inicial (ej. desde la BD)
        public void SetProducts(IEnumerable<ProductDto> products)
        {
            Products = products.ToList();
            IsLoaded = true;
            NotifyStateChanged();
        }

        // Método para agregar un producto al estado localmente
        public void AddProduct(ProductDto product)
        {
            Products.Add(product);
            NotifyStateChanged();
        }

        // Método para eliminar del estado local
        public void RemoveProduct(int productId)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Products.Remove(product);
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        public async ValueTask DisposeAsync()
        {
            if (_hubConnection is not null)
            {
                await _hubConnection.DisposeAsync();
            }
        }
    }
}
