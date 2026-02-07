using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SA.Domain.Entities;
using SA.Domain.Identity; // Donde hayas movido ApplicationUser

namespace SA.Infrastructure.Data // Namespace ajustado
{
    // Asegúrate de que ApplicationUser esté visible aquí
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}