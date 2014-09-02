using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HermesNet.Model;

namespace HermesNet.DAO
{
    public class CargoDAO
    {
        Conexion conn;
        SqlConnection _con;
        
        public CargoDAO()
        {
            conn = new Conexion();
            _con = conn.Conectar();
        }

        /// <summary>
        /// Retorna todos los cargos que están en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<CargoVO> ObtenerTodosLosCargos()
        {
            List<CargoVO> lcvo = new List<CargoVO>();
            try
            {
                SqlCommand cmd = new SqlCommand("", _con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ObtenerTodosLosCargos";
                cmd.Connection.Close();
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CargoVO cvo = new CargoVO();
                    cvo.Id_cargo = (long)(dr["id_cargo"]);
                    cvo.Descripcion = dr["descripcion"].ToString();
                    lcvo.Add(cvo);
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                if (_con.State == System.Data.ConnectionState.Open)
                {
                    _con.Close();
                }
                throw;
            }
            return lcvo;
        }
    }
}
