using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.Model;
using System.Data.SqlClient;

namespace HermesNet.DAO
{
    public class AseguradoraDAO
    {
        private Conexion con;
        public AseguradoraDAO()
        {
            con = new Conexion();
        }
        public AseguradoraVO ObtenerAseguradoraPorRut(long rut, char dv)
        {
            AseguradoraVO ase = new AseguradoraVO();
            SqlCommand cmd = new SqlCommand("", con.Conectar());
            try
            {                
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_obtenerAseguradoraPorRut";
                cmd.Parameters.Add("@rut", System.Data.SqlDbType.BigInt).Value = rut;
                cmd.Parameters.Add("@dv", System.Data.SqlDbType.Char).Value = dv;

                cmd.Connection.Close();
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ase.Rut = (long)dr["rut"];
                    ase.Dv = Convert.ToChar((string)(dr["dv"])); 
                    ase.RazonSocial = (string)dr["RazonSocial"];
                    ase.Direccion = (string)dr["direccion"];
                    ase.Telefono = (string)dr["telefono"];
                    ase.Email = (string)dr["email"];
                }
                cmd.Connection.Close();
                return ase;
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

        public List<AseguradoraVO> ObtenerAseguradoraPorRazonSocial(string razonSocial)
        {
            List<AseguradoraVO> aseg = new List<AseguradoraVO>();
            SqlCommand cmd = new SqlCommand("", con.Conectar());
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_obtenerAseguradoraPorRazonSocial";
                cmd.Parameters.Add("@razon_social", System.Data.SqlDbType.VarChar).Value = razonSocial;

                cmd.Connection.Close();
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    AseguradoraVO aseguradora = new AseguradoraVO();
                    aseguradora.Rut = (long)dr["rut"];
                    aseguradora.Dv = Convert.ToChar((string)dr["dv"]);
                    aseguradora.RazonSocial = (string)dr["RazonSocial"];
                    aseguradora.Direccion = (string)dr["direccion"];
                    aseguradora.Telefono = (string)dr["telefono"];
                    aseguradora.Email = (string)dr["email"];
                    aseg.Add(aseguradora);
                }
                cmd.Connection.Close();
                return aseg;
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
