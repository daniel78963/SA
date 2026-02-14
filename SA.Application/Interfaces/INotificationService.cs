using SA.Application.DTOs;

namespace SA.Application.Interfaces
{
    public interface INotificationService
    {
        Task NotifyProductChanged(ProductDto product, string changeType); // changeType: "Create", "Update", "Delete"
    }
}
