using PMILUGAR2025.web.Data.Dtos;
namespace PMILUGAR2025.web.Data.Services
{
    public class ReservaServices(ApplicationDbContext db) 
    {
        public List<ReservaDtos> Consultar()
        {
            return db.Reservas
                .Select(r => new ReservaDtos
                {
                    Id = r.Id,
                    ApartamentoId = r.ApartamentoId,
                    FechaInicio = r.FechaInicio,
                    FechaFin = r.FechaFin,
                    Estado = r.Estado

                }).ToList();
        }


    }
}
