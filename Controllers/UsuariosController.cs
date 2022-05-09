using Microsoft.AspNetCore.Mvc; 
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;
namespace HolaMVC.Controllers
{
    public class UsuariosController:Controller //Extender de la clase controller
    {
        private IWebHostEnvironment _env;  //Variable privada de la interfaz IHostingEnviroment
        //Crear el contructor
        public UsuariosController(IWebHostEnvironment env)
        {
            _env = env;
        }
        //Metodo para retornar una Vista
        public IActionResult Index()
        {
            return View();
        }
        //Metodo para abrir el archivo
        public FileStreamResult Pdf()
        {
            string FilePath = Path.Combine(_env.WebRootPath,"download/","404.pdf");
            string FilePath404 = Path.Combine(_env.WebRootPath,"download/","404.pdf");
            if(System.IO.File.Exists(FilePath))
            {
                FileStream fs = new FileStream(FilePath, FileMode.Open );
                return File(fs, "application/pdf");
                //return File(fs,"application/octet-stream","Archivo.pdf"); //Descargar el archivo encontrado
            }else{
                FileStream fs = new FileStream(FilePath404, FileMode.Open);
                return File(fs, "application/pdf");
            }

        }

        public IActionResult Registro(bool encontrado)
        {
            if(encontrado)
            {
                return Content("Registro encontrado");
            }else{
                return StatusCode(404);
            }
        }
    }
    
}