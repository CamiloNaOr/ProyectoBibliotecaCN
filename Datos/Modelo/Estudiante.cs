using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaCN.Datos.Modelo
{
    public class Estudiante
    {
        [Key]
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }

    }
}
