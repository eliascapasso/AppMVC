using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class DocumentoBL
    {
        DocumentoDAL _dal = new DocumentoDAL();

        public int AgregarDocumento(DocumentoEN dEN)
        {
            return _dal.AgregarDocumento(dEN);
        }

        public List<DocumentoEN> ConsultarDocumentos()
        {
            return _dal.ConsultarDocumentos();
        }
    }
}