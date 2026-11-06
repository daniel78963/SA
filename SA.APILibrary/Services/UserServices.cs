using Microsoft.AspNetCore.Identity;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Services
{
    public class UserServices : IUserServices
    {
        private readonly UserManager<User> userManager;
        private readonly IHttpContextAccessor contextAccessor;

        public UserServices(UserManager<User> userManager, IHttpContextAccessor contextAccessor)
        { 
            //IHttpContextAccessor para poder acceder al contexto HTTP y obtener información sobre el usuario autenticado (claims)
            this.userManager = userManager;
            this.contextAccessor = contextAccessor;
        }

        public async Task<User?> GetCurrentUserAsync()
        {
            var emailClaim = contextAccessor.HttpContext?.User?
                .Claims.Where(c => c.Type == "email")
                .FirstOrDefault();
            if (emailClaim is null)
            {
                return null;
            }

            var email = emailClaim.Value;
            return await userManager.FindByEmailAsync(email);
        }
    }
}
