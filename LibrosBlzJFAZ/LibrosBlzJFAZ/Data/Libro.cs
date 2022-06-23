namespace LibrosBlzJFAZ.Data
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titutlo { get; set; } = null!;
        public string Ano { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public string NumPaginas { get; set; } = null!;
        public int IdAutor { get; set; }
        public string NomAutor { get; set; } = null!;
    }
}
