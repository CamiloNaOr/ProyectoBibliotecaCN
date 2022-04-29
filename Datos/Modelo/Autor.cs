using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaCN.Datos.Modelo
{
    public class Autor
    {
        [Key]
        public string Nombre { get; set; }
        public int CantidadLibros { get; set; }
        public string Nacionalidad { get; set; }
        public int edad { get; set; }
        public string Genero { get; set; }
    }
}
