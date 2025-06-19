namespace PMILUGAR2025.web.Data.Dtos
{
    public class ReservaDtos
    {
        public int Id { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; }
        public int ApartamentoId { get; set; }
        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreApartamento { get; set; }
        public string Contacto { get; set; }

    }
}
