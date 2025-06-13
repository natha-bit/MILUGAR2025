namespace PMILUGAR2025.web.Data.Dtos
{
    public class ReservaDtos
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public int ApartamentoId { get; set; }
        public int UsuarioId { get; set; }
    }
}
