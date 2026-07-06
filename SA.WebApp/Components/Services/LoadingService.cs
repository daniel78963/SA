namespace SA.WebApp.Services
{
    public class LoadingService
    {
        public bool IsLoading { get; private set; }

        // Evento al que se suscribirá el MainLayout para enterarse de los cambios
        public event Action? OnStateChanged;

        public void Show()
        {
            if (!IsLoading)
            {
                IsLoading = true;
                NotifyStateChanged();
            }
        }

        public void Hide()
        {
            if (IsLoading)
            {
                IsLoading = false;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}