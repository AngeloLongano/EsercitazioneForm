using Esercitazione.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Esercitazione.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            var model = new IndexModel();

            model.Title = "Form Riscontro";
            model.LabelTitleProblem = "Titolo del problema";
            model.LabelNameUser = "Nome segnalatore";
            model.LabelEmailUser = "Email segnalatore";
            model.LabelDescription = " Descrizione problema";
            model.LabelButton = "invia";

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            return View(model);
        }
    }
}