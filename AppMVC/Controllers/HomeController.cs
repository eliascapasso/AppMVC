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

        public ActionResult BtnCargarImagenDni()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult BtnCargarImagenDni(HttpPostedFileBase file)
        {
            SubirArchivoModelo modelo = new SubirArchivoModelo();
            if (file != null){
                String ruta = Server.MapPath("~/Temp/");
                ruta += file.FileName;

                modelo.SubirArchivo(ruta, file);
                ViewBag.error = modelo.error;
                ViewBag.correcto = modelo.Confirmacion;
            }

            return View("Index");
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