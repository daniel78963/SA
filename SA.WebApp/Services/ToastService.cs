using System.Timers;

namespace SA.WebApp.Services
{
    // Tipos de mensajes
    public enum ToastLevel
    {
        Info,
        Success,
        Warning,
        Error
    }

    public class ToastService : IDisposable
    {
        // Evento al que se suscribirá el componente visual
        public event Action<string, ToastLevel>? OnShow;

        // Método para llamar al Toast desde cualquier lugar
        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
        }

        // Atajos útiles
        public void ShowSuccess(string message) => ShowToast(message, ToastLevel.Success);
        public void ShowError(string message) => ShowToast(message, ToastLevel.Error);
        public void ShowWarning(string message) => ShowToast(message, ToastLevel.Warning);
        public void ShowInfo(string message) => ShowToast(message, ToastLevel.Info);

        public void Dispose()
        {
            // Limpieza si fuera necesaria
        }
    }
}