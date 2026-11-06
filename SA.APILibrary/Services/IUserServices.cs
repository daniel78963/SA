using Microsoft.AspNetCore.Identity;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Services
{
    public interface IUserServices
    {
        Task<User?> GetCurrentUserAsync();
    }
}