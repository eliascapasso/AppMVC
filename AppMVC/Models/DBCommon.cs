using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppMVC.Models
{
    public class DBCommon
    {
        private static string Conn = @"Data Source=LAPTOP-ELIAS;Initial Catalog=AppMVC;Integrated Security=True";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }
    }
}