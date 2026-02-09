using SA.Application.DTOs;

namespace SA.WebApp.State
{
    public class ProductStateContainer
    {
        // El estado real (la lista de productos)
        public List<ProductDto> Products { get; private set; } = new();

        // Propiedad para saber si ya cargamos datos (opcional, para evitar recargas)
        public bool IsLoaded { get; private set; } = false;

        // Evento que se dispara cuando el estado cambia
        public event Action? OnChange;

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
    }
}
