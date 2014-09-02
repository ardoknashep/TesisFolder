using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.Model;
using System.Data.SqlClient;

namespace HermesNet.DAO
{
    public class RegionDAO
    {
        private Conexion _con;

        public RegionDAO()
        {
            _con = new Conexion();
        }

        public List<RegionVO> ObtenerRegiones()
        {
            SqlCommand cmd = new SqlCommand("",_con.Conectar());
            List<RegionVO> lreg = new List<RegionVO>();

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_obtenerRegiones";

                cmd.Connection.Close();
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    RegionVO reg = new RegionVO();
                    reg.Id_region = (long)dr["id_region"];
                    reg.Descripcion = (string)dr["descripcion"];
                    lreg.Add(reg);
                }
                cmd.Connection.Close();
                return lreg;
            }
            catch (Exception)
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                throw;
            }
        }

    }
}
