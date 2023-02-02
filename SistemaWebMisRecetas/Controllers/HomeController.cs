using Microsoft.AspNetCore.Mvc;
using System;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Nombre = "Bienvenido al recetario.";

            ViewBag.Fecha = DateTime.Now.ToString();

            return View();

        }
    }
}
