using Microsoft.AspNetCore.Identity;
using PMILUGAR2025.web.Data.Entities;

namespace PMILUGAR2025.web.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Apartamento> Apartamentos { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }

    }

}
