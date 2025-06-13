using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMILUGAR2025.web.Data.Entities
{
    [Table("Reservas")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public String Estado { get; set; }
        public int ApartamentoId { get; set; }
        [ForeignKey("ApartamentoId")]
        public Apartamento Apartamento { get; set; }
        public ApplicationUser UsuarioId { get; set; }
        
    }
}
