using RegistroEstudiante.data.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroEstudiante.web.Controllers
{
    public class HomeController : Controller
    {

        IEstudiantesService service;
        ICursosService cursosService;

       public HomeController(IEstudiantesService servicio, ICursosService cursosServicio) {
            this.service = servicio;
            this.cursosService = cursosServicio;
        }
        public ActionResult Index()
        {
            var lista = this.service.Listar();
            return View(lista);
        }

        public ActionResult About()
        {
            var cursos = this.cursosService.ListarCurso();
            //ViewBag.Message = "Your application description page.";

            return View(cursos);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}