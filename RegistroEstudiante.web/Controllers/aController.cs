using RegistroEstudiante.web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroEstudiante.web.Controllers
{
    public class aController : Controller
    {
        // GET: a
        public ActionResult Index()
        {
            var saludarviewmodel = new SaludarViewModel();
            saludarviewmodel.saludar = ConfigurationManager.AppSettings["saludo"];
            return View(saludarviewmodel);
        }
    }
}