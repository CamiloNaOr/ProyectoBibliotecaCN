using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaCN.Datos.Modelo;

namespace ProyectoBibliotecaCN.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext
    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) : base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        //crear  3 propiedades restantes (autor, estudiante, prestamo)
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }
}
