using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace HermesNet.DAO
{
    public class Conexion
    {
        private string strCon;
        public Conexion()
        {
            strCon = ConfigurationManager.ConnectionStrings["tesisConnectionString"].ConnectionString;
        }

        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                return con;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
