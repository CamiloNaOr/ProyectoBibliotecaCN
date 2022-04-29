using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaCN.Datos.Modelo
{
    public class Prestamo
    {
        [Key]
        public string NombreEstudiante { get; set; }
        public string NombreLibro { get; set; }
        public string NombreAutor { get; set; }
        public string FechaPrestado { get; set; }
        public string FechaDeRegreso { get; set; }
    }
}
