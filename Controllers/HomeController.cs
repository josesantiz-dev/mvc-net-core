using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMVC.Models;

namespace HolaMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Retorna una Vista
    public IActionResult Index()
    {
        ViewBag.Nombre = "Jose Luis";
        ViewData["Apellidos"] = "Fuente Campos";
        TempData["Usuario"] = "joseph18";
        List<string> Frutas = new List<string>(){
            "Manzana","Pera","Uva","Sandia","Mandarina"
        };
        ViewData["Frutas"] = Frutas;
        ViewBag.Frutas = Frutas;
        TempData["Frutas"] = Frutas;
        return View();
    }


    [BindProperty]
    public Persona _Persona {get;set;}
    public IActionResult SetPersona()
    {
        return Json(_Persona);
    }



    public IActionResult Usuarios()
    {
        ViewData["Usuarios"] = new List<Usuario>(){
            new Usuario(){
                Nombre = "Jose",
                Apellidos = "Santiz Ruiz",
                Correo = "jose@gmail.com",
                Edad = 32
            },
             new Usuario(){
                Nombre = "Juan",
                Apellidos = "Santiz Ruiz",
                Correo = "juan@gmail.com",
                Edad = 38
            },
             new Usuario(){
                Nombre = "Pedro",
                Apellidos = "Santiz Ruiz",
                Correo = "pedro@gmail.com",
                Edad = 34
            },
            
        };
        return View();
    }
    public string HolaMundo(string nombre)
    {
        return "Hola mundo"+ nombre;
    }

    public ViewResult Acerca()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
