namespace LibrosBlzJFAZ.Data
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string FechaNacimiento { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Correo { get; set; } = null!;
    }
}
