using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppMVC.Models
{
    public class DocumentoDAL
    {
        IDbConnection _conn = DBCommon.Conexion();

        public int AgregarDocumento(DocumentoEN pEN)
        {
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("AgregarDocumento", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@dni_difunto", pEN.DniDifunto));
            _Comand.Parameters.Add(new SqlParameter("@certificado_defuncion", pEN.CertificadoDefuncion));
            _Comand.Parameters.Add(new SqlParameter("@dni_contratante", pEN.DniContratante));
            _Comand.Parameters.Add(new SqlParameter("@declaracion_jurada", pEN.DeclaracionJurada));
            _Comand.Parameters.Add(new SqlParameter("@permiso_inhumacion", pEN.PermisoInhumación));
            _Comand.Parameters.Add(new SqlParameter("@formulario_607", pEN.Formulario607));
            _Comand.Parameters.Add(new SqlParameter("@acreditacion_vinculo", pEN.AcreditacionVinculo));
            _Comand.Parameters.Add(new SqlParameter("@dni_vinculante", pEN.DniVinculante));
            _Comand.Parameters.Add(new SqlParameter("@autorizacion_cceremacion", pEN.AutorizacionCremacion));

            int Resultado = _Comand.ExecuteNonQuery();
            _conn.Close();
            return Resultado;
        }

        public List<DocumentoEN> ConsultarDocumentos()
        {
            _conn.Open();
            SqlCommand _comand = new SqlCommand("ConsultarDocumentos", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
            List<DocumentoEN> _lista = new List<DocumentoEN>();
            while (_reader.Read())
            {
                DocumentoEN pEN = new DocumentoEN();
                pEN.IdDocumento = _reader.GetInt64(0);
                pEN.CertificadoDefuncion = _reader.GetString(1);
                pEN.DniContratante = _reader.GetString(2);
                pEN.DeclaracionJurada = _reader.GetString(3);
                pEN.PermisoInhumación = _reader.GetString(4);
                pEN.Formulario607 = _reader.GetString(5);
                pEN.AcreditacionVinculo = _reader.GetString(6);
                pEN.DniVinculante = _reader.GetString(7);
                pEN.AutorizacionCremacion = _reader.GetString(8);

                _lista.Add(pEN);
            }

            _conn.Close();
            return _lista;
        }
    }
}