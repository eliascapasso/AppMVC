using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            SubirArchivoModelo modelo = new SubirArchivoModelo();
            if (file != null){
                String ruta = Server.MapPath("~/Temp/");
                ruta += file.FileName;

                modelo.SubirArchivo(ruta, file);

                ViewBag.ruta = ruta;
                ViewBag.error = modelo.error;
                ViewBag.correcto = modelo.Confirmacion;
            }

            return View();
        }

        public ActionResult Ver()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}