using Microsoft.AspNetCore.Identity;
using SA.Domain.Entities.SA;

namespace SA.Domain.Identity
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //// Agrega la llave foránea opcional a Persona
        //public int? PersonaId { get; set; }

        //// Propiedad de navegación
        //public virtual Persona? Persona { get; set; }

        // Enlace suave: Solo guardamos el ID para saber quién es en el ERP, 
        // pero NO usamos "public virtual Persona Persona" para no enredar los DbContexts.
        public int? PersonaId { get; set; }

        // Puedes agregar otros campos propios de seguridad aquí si quieres a futuro
    }

}
