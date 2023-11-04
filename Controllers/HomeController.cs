using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EncuestaDojoValidacion.Models;


namespace EncuestaDojoValidacion.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }


    [HttpGet]
    [Route("")]
    public IActionResult Index(){
        return View("Index");
    }

    [HttpGet]
    [Route("privacy")]
    public IActionResult Privacy(){
        return View("Privacy");
    }


    [HttpPost("/")]
    public IActionResult AgregarNuevaEncuesta(Encuesta encuesta){
        if (ModelState.IsValid){
            ViewBag.Name = encuesta.Name; 
            ViewBag.Location = encuesta.Location;
            ViewBag.FavoriteLanguage = encuesta.FavoriteLanguage;
            ViewBag.Comment = encuesta.Comment;
            return View("Result");
        }
        return View("Index");
    }


    [HttpGet]
    [Route("result")]
    public IActionResult Result(){
        return View("Result");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
