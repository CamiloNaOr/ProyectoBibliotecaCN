

using Microsoft.AspNetCore.Mvc;

namespace ProyectoBibliotecaCN.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController: ControllerBase
    {
        //propiedad publica
        public String PropiedadBiblioteca { get; set; }

        public BibliotecaController()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPost]
        public string AgregarLibro()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPut]
        public string ActualizarLibro()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpDelete]
        public string EliminarLibro()
        {
            //funcion
            return "No seas pendejo";
        }
        [HttpGet]
        public string ObtenerAutro()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPost]
        public string AgregarAutor()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPut]
        public string ActualizarAutor()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpDelete]
        public string EliminarAutor()
        {
            //funcion
            return "No seas pendejo";
        }
        [HttpGet]
        public string ObtenerEstudiante()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPost]
        public string AgregarEstudiante()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPut]
        public string ActualizarEstudiante()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpDelete]
        public string EliminarEstudiante()
        {
            //funcion
            return "No seas pendejo";
        }
        [HttpGet]
        public string ObtenerPrestamo()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPost]
        public string AgregarPrestamo()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpPut]
        public string ActualizarPrestamo()
        {
            //funcion
            return "No seas pendejo";
        }

        [HttpDelete]
        public string EliminarPrestamo()
        {
            //funcion
            return "No seas pendejo";
        }
    }
}
