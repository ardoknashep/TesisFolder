using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HermesNet.Model;

namespace HermesNet.DAO
{
    public class RolDAO
    {
        Conexion conn;
        SqlConnection _con;

        public RolDAO()
        {
            conn = new Conexion();
            _con = conn.Conectar();
        }

        /// <summary>
        /// Retorna todos los roles de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<RolVO> ObtenerTodosLosRoles()
        {
            List<RolVO> lrvo = new List<RolVO>();
            try
            {
                SqlCommand cmd = new SqlCommand("", _con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ObtenerTodosLosRoles";
                cmd.Connection.Close();
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RolVO rvo = new RolVO();
                    rvo.IdRol = (long)(dr["id_rol"]);
                    rvo.Descripcion = dr["descripcion"].ToString();
                    lrvo.Add(rvo);
                }
                cmd.Connection.Close();
            }
            catch (Exception)
            {
                if (_con.State == System.Data.ConnectionState.Open)
                {
                    _con.Close();
                }
                throw;
            }
            return lrvo;
        }
    }
}
