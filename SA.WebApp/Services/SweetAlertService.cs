using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;

namespace SA.WebApp.Services
{
    public class SweetAlertService
    {
        private readonly IJSRuntime _js;

        public SweetAlertService(IJSRuntime js)
        {
            _js = js;
        }

        // 1. Popup de Confirmación (Estilo estandarizado para borrar)
        public async Task<bool> ConfirmDeleteAsync(string title = "¿Estás seguro?", string text = "No podrás revertir esta acción", string confirmButtonText = "Sí, eliminar")
        {
            var options = new
            {
                title = title,
                text = text,
                icon = "warning",
                showCancelButton = true,
                confirmButtonColor = "#d33", // Rojo para peligro
                cancelButtonColor = "#3085d6", // Azul para cancelar
                confirmButtonText = confirmButtonText,
                cancelButtonText = "Cancelar"
            };

            var result = await _js.InvokeAsync<JsonElement>("Swal.fire", options);

            // SweetAlert devuelve un objeto con la propiedad "isConfirmed"
            if (result.TryGetProperty("isConfirmed", out var isConfirmed))
            {
                return isConfirmed.GetBoolean();
            }

            return false;
        }

        // 2. Popup de Éxito (Simple)
        public async Task ShowSuccessAsync(string title, string message)
        {
            await _js.InvokeVoidAsync("Swal.fire", title, message, "success");
        }

        // 3. Toast de Éxito (Notificación pequeña en la esquina que desaparece sola)
        // Esta es ideal para "Acción realizada" sin obligar al usuario a dar click en OK
        public async Task ShowToastSuccessAsync(string message)
        {
            var options = new
            {
                toast = true,
                position = "top-end",
                showConfirmButton = false,
                timer = 3000,
                timerProgressBar = true,
                icon = "success",
                title = message
            };

            await _js.InvokeVoidAsync("Swal.fire", options);
        }

        // 4. Popup de Error
        public async Task ShowErrorAsync(string title, string message)
        {
            await _js.InvokeVoidAsync("Swal.fire", title, message, "error");
        }
    }
}