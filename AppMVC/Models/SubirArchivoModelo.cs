using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class SubirArchivoModelo
    {
        public String Confirmacion { get; set; }

        public Exception error { get; set; }

        public void SubirArchivo(String ruta, HttpPostedFileBase file)
        {
            try
            {
                file.SaveAs(ruta); 
                this.Confirmacion = "Imagen guardada";
            }
            catch (Exception e)
            {
                this.error = e;
            }
        }
    }
}