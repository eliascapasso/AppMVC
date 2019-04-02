using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class DocumentoEN
    {
        public Int64 IdDocumento { get; set; }

        public string DniDifunto { get; set; }

        public string CertificadoDefuncion { get; set; }

        public string DniContratante { get; set; }

        public string DeclaracionJurada { get; set; }

        public string PermisoInhumación { get; set; }

        public string Formulario607 { get; set; }

        public string AcreditacionVinculo { get; set; }

        public string DniVinculante { get; set; }

        public string AutorizacionCremacion { get; set; }
    }
}