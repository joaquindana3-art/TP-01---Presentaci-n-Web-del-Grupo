using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01_Dana_Grinblat_Poniachik.Models;

namespace TP01_Dana_Grinblat_Poniachik.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        Grupo grupo = new Grupo();
        ViewBag.grupo = grupo;
        return View();

    }

    public IActionResult SelectIntegrante(int dni)
    {

        Grupo grupo = new Grupo();
        Integrante integrante = grupo.getIntegrante(dni);
        ViewBag.integrante = integrante;
        ViewBag.dni = dni;
        return RedirectToAction("infoIntegrante", "Home");
        
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
