using PMILUGAR2025.web.Data.Dtos;
namespace PMILUGAR2025.web.Data.Services
{
    public interface IReservaServices
    {
        bool Crear(ReservaDtos reserva);
    }

    public class ReservaServices(ApplicationDbContext db) : IReservaServices
    {
        public List<ReservaDtos> Consultar()
        {
            return db.Reservas
                .Select(r => new ReservaDtos
                {
                    Id = r.Id,
                    ApartamentoId = r.ApartamentoId,
                    Estado = r.Estado

                }).ToList();
        }
        public bool Crear(ReservaDtos reserva)
        {
            var nuevaReserva = new Entities.Reserva
            {
                FechaSolicitud = DateTime.Now,
                Estado = reserva.Estado,
                ApartamentoId = reserva.ApartamentoId,
                NombreUsuario = reserva.NombreUsuario,
                NombreApartamento = reserva.NombreApartamento,
                Contacto = reserva.Contacto,
                UsuarioId = reserva.UsuarioId,
            };
            db.Reservas.Add(nuevaReserva);
            return db.SaveChanges() > 0;

        }

    }
}
