using Microsoft.AspNetCore.Identity;

namespace SA.APILibrary.Services
{
    public class UserServices : IUserServices
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IHttpContextAccessor contextAccessor;

        public UserServices(UserManager<IdentityUser> userManager, IHttpContextAccessor contextAccessor)
        { 
            //IHttpContextAccessor para poder acceder al contexto HTTP y obtener información sobre el usuario autenticado (claims)
            this.userManager = userManager;
            this.contextAccessor = contextAccessor;
        }

        public async Task<IdentityUser?> GetCurrentUserAsync()
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
