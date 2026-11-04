using Microsoft.AspNetCore.Identity;

namespace SA.APILibrary.Services
{
    public interface IUserServices
    {
        Task<IdentityUser?> GetCurrentUserAsync();
    }
}