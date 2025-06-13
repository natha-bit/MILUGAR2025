namespace PMILUGAR2025.web.Data.Entities
{
    public class ImagenApartamento
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int ApartamentoId { get; set; }
        public Apartamento Apartamento { get; set; } = null!;
    }
}
