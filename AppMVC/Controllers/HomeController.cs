using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppMVC.Models;

namespace AppMVC.Controllers
{
    public class HomeController : Controller
    {
        DocumentoBL _bl = new DocumentoBL();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(DocumentoEN dEN)
        {
            _bl.AgregarDocumento(dEN);
            return RedirectToAction ("Index");
        }

        public ActionResult Ver()
        {
            return View("Ver");
        }
    }
}