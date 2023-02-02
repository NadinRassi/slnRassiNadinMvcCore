using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBRecetasContext context;

        public RecetaController(DBRecetasContext context)
        {
            this.context = context;

        }

        //Todas
        public IActionResult Index()
        {
            return View(context.Recetas.ToList());
        }

        //Traer una
        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }

        //POR APELLIDO GET
        [HttpGet]
        public IActionResult RecetasPorApellido(string apellido)
        {
            var recetasPorApellido = (from rec in context.Recetas where rec.Apellido == apellido select rec).ToList();

            return View("Index", recetasPorApellido);
        }

        //POR NOMBRE GET
        [HttpGet]
        public IActionResult RecetasPorAutor(string autor)
        {
            var recetasPorAutor = (from rec in context.Recetas where rec.Autor == autor select rec).ToList();

            return View("Index", recetasPorAutor);
        }

        //DETALLE GET
        [HttpGet]
        public ActionResult Detalle(int id)
        {
            Receta receta = TraerUna(id);

            if (receta == null)
            {
                return NotFound();
            }

            return View("Detalle", receta);
        }

        //CREATE GET
        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta);
        }

        //CREATE POST
        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);

                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(receta);
        }

        //EDITAR GET
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var receta = TraerUna(id);

            if (receta == null)
            {
                return NotFound();
            }

            return View("Editar", receta);
        }

        //EDITAR POST
        [HttpPost]
        [ActionName("Editar")]
        public ActionResult EditConfirmed(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(receta).State = EntityState.Modified;

                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(receta);
        }

        //ELIMINAR GET
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var receta = TraerUna(id);

            if (receta == null)
            {
                return NotFound();
            }

            return View("Eliminar", receta);
        }

        //ELIMINAR POST
        [ActionName("Eliminar")]
        [HttpPost]
        public ActionResult EliminarConfirmed(int id)
        {
            var receta = TraerUna(id);

            if (receta == null)
            {
                return NotFound();
            }

            context.Recetas.Remove(receta);

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
