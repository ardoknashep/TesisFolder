using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.Model;
using System.Data.SqlClient;

namespace HermesNet.DAO
{
    public class EmpresaPolizaDAO
    {
        private Conexion con;

        public EmpresaPolizaDAO()
        {
            con = new Conexion();
        }

        public EmpresaPolizaVO BuscarRutEP(long rut, char dv)
        {
            SqlCommand cmd = new SqlCommand("", con.Conectar());
            EmpresaPolizaVO empP = new EmpresaPolizaVO();

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_buscarRutEmpresaPoliza";
                cmd.Parameters.Add("@rut",System.Data.SqlDbType.BigInt).Value = rut;
                cmd.Parameters.Add("@dv",System.Data.SqlDbType.Char).Value = dv;

                cmd.Connection.Close();
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empP.Rut = (long)dr["rut"];
                    empP.Dv = Convert.ToChar((string)dr["dv"]);
                    empP.RazonSocial = (string)dr["RazonSocial"];
                }
                cmd.Connection.Close();
                return empP;
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

        public int CrearEmpresaPoliza(long rut, char dv, string razonSocial, string direccion, long idComuna, string telefono, string email)
        {
            SqlCommand cmd = new SqlCommand("", con.Conectar());
            //SqlCommand cmdB = new SqlCommand("", con.Conectar());
            //EmpresaPolizaVO emp = new EmpresaPolizaVO();
            int cuenta;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_crearEmpresaPoliza";
                cmd.Parameters.Add("@rut", System.Data.SqlDbType.BigInt).Value = rut;
                cmd.Parameters.Add("@dv", System.Data.SqlDbType.Char).Value = dv;
                cmd.Parameters.Add("@razonSocial", System.Data.SqlDbType.VarChar).Value = razonSocial;
                cmd.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = direccion;
                cmd.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = telefono;
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@id_Comuna_EP", System.Data.SqlDbType.BigInt).Value = idComuna;

                cmd.Connection.Close();
                cmd.Connection.Open();

                cuenta = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                //cmdB.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdB.CommandText = "sp_buscarRutEmpresaPoliza";
                //cmdB.Parameters.Add("@rut", System.Data.SqlDbType.BigInt).Value = rut;
                //cmdB.Parameters.Add("@dv", System.Data.SqlDbType.Char).Value = dv;

                //cmdB.Connection.Close();
                //cmdB.Connection.Open();

                //SqlDataReader dr = cmdB.ExecuteReader();
                //if (dr.Read())
                //{
                //    emp.RazonSocial = (string)dr["RazonSocial"];
                //}
                //cmdB.Connection.Close();
                return cuenta;
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

        public List<EmpresaPolizaVO> ObtenerEmpPolizaPorRazonSocial(string razonSocial)
        {
            SqlCommand cmd = new SqlCommand("", con.Conectar());
            List<EmpresaPolizaVO> empPoli = new List<EmpresaPolizaVO>();
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_obtenerEmpPolizaPorRazonSocial";
                cmd.Parameters.Add("@razon_social", System.Data.SqlDbType.VarChar).Value = razonSocial;

                cmd.Connection.Close();
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmpresaPolizaVO empPol = new EmpresaPolizaVO();
                    empPol.Rut = (long)dr["rut"];
                    empPol.Dv = Convert.ToChar((string)dr["dv"]);
                    empPol.RazonSocial = (string)dr["RazonSocial"];
                    empPoli.Add(empPol);
                }
                cmd.Connection.Close();
                return empPoli;
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
