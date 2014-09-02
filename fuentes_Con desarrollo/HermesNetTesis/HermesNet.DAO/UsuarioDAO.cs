using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HermesNet.Model;

namespace HermesNet.DAO
{
    public class UsuarioDAO
    {
        private Conexion conn;
        private SqlConnection _con;

        public UsuarioDAO()
        {
            conn = new Conexion();
            _con = conn.Conectar();
            
        }

        /// <summary>
        /// Obtiene un usuario buscado
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rut"></param>
        /// <returns></returns>
        public UsuarioVO ObtenerUsuarioByRut(string username, int rut)
        {
            UsuarioVO uvo = new UsuarioVO();
            try
            {
                SqlCommand cmd = new SqlCommand("", _con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ObtenerUsuarioByRut";
                cmd.Parameters.Add("@ivUserNameConsultante", System.Data.SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@iiRutUsuarioAConsultar", System.Data.SqlDbType.Int).Value = rut;
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string mensaje;
                    mensaje = dr["MENSAJE"].ToString();
                    if (mensaje == "OK")
                    {
                        uvo.Rut = (int)(dr["rut"]);
                        uvo.Dv = Convert.ToChar((string)dr["dv"]);
                        uvo.Nombre = dr["nombre"].ToString();
                        uvo.Apellido_p = dr["apellido_p"].ToString();
                        uvo.Apellido_m = dr["apellido_m"].ToString();
                        uvo.Email = dr["email"].ToString();
                        uvo.Cargo.Id_cargo = (long)(dr["id_cargo"]);
                        uvo.Cargo.Descripcion = dr["DescripcionCargo"].ToString();
                        uvo.UserName = dr["USERNAME"].ToString();
                        uvo.Passwd = (byte[])(dr["passwd"]);
                        uvo.Rol.IdRol = (long)(dr["IdRol"]);
                        uvo.Rol.Descripcion = dr["DescripcionRol"].ToString();
                    }
                    else
                    {
                        throw new ExcepcionPersonalizadaVO("UsuarioDAO", "Usuario sin Acceso a esta información");
                    }
                }
                cmd.Connection.Close();
            }
            catch (ExcepcionPersonalizadaVO ex)
            {
                if (_con.State == System.Data.ConnectionState.Open)
                {
                    _con.Close();
                }
                throw;
            }
            catch (Exception)
            {
                if (_con.State == System.Data.ConnectionState.Open)
                {
                    _con.Close();
                }
                throw;
            }
            return uvo;
        }

        public List<UsuarioVO> ObtenerTodosLosUsuarios(string username)
        {
            List<UsuarioVO> lvo = new List<UsuarioVO>();
            try
            {
                SqlCommand cmd = new SqlCommand("", _con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ObtenerTodosLosUsuarios";
                cmd.Parameters.Add("@ivUserNameConsultante", System.Data.SqlDbType.VarChar).Value = username;
                cmd.Connection.Close();
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    UsuarioVO uvo = new UsuarioVO();
                    if (dr["MENSAJE"].ToString() == "OK")
                    {
                        uvo.Rut = (int)(dr["rut"]);
                        uvo.Dv = Convert.ToChar((string)dr["dv"]);
                        uvo.Nombre = dr["nombre"].ToString();
                        uvo.Apellido_p = dr["apellido_p"].ToString();
                        uvo.Apellido_m = dr["apellido_m"].ToString();
                        uvo.Email = dr["email"].ToString();
                        uvo.Cargo.Id_cargo = (long)(dr["id_cargo"]);
                        uvo.Cargo.Descripcion = dr["DescripcionCargo"].ToString();
                        uvo.UserName = dr["USERNAME"].ToString();
                        uvo.Passwd = (byte[])(dr["passwd"]);
                        uvo.Rol.IdRol = (long)(dr["IdRol"]);
                        uvo.Rol.Descripcion = dr["DescripcionRol"].ToString();
                        lvo.Add(uvo);
                    }
                }
                cmd.Connection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            return lvo;
        }

    }
}
