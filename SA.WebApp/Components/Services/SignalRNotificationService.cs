using Microsoft.AspNetCore.SignalR;
using SA.Application.DTOs;
using SA.Application.Interfaces;
using SA.WebApp.Hubs;

namespace SA.WebApp.Components.Services
{
    public class SignalRNotificationService : INotificationService
    {
        private readonly IHubContext<ProductHub> _hubContext;

        public SignalRNotificationService(IHubContext<ProductHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task NotifyProductChanged(ProductDto product, string changeType)
        {
            // Enviamos un mensaje llamado "ReceiveProductUpdate" a TODOS los clientes conectados
            await _hubContext.Clients.All.SendAsync("ReceiveProductUpdate", product, changeType);
        }
    }
}
