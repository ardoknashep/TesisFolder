using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.Model;
using System.Data.SqlClient;

namespace HermesNet.DAO
{
    public class ComunaDAO
    {
        private Conexion con;

        public ComunaDAO()
        {
            con = new Conexion();
        }

        public List<ComunaVO> ObtenerComuna(long idRegion)
        {
            SqlCommand cmd = new SqlCommand("",con.Conectar());
            List<ComunaVO> lcom = new List<ComunaVO>();
            //RegionVO reg = new RegionVO();

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_obtenerComunaPorIdRegion";
                cmd.Parameters.Add("@id_region", System.Data.SqlDbType.BigInt).Value = idRegion;
                //cmd.CommandText = "sp_obtenerComunaPorNombreRegion";
                //cmd.Parameters.Add("@nombreRegion", System.Data.SqlDbType.VarChar).Value = nomRegion;
                //cmd.CommandText = "sp_obtenerRegionPorNombre";
                //cmd.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = nomRegion;

                cmd.Connection.Close();
                cmd.Connection.Open();

                //SqlDataReader dr = cmd.ExecuteReader();

                //if (dr.Read())
                //{
                //    reg.Id_region = (long)dr["id_region"];
                //}
                SqlDataReader drC = cmd.ExecuteReader();
                while (drC.Read())
                {
                    ComunaVO com = new ComunaVO();
                    com.Id_comuna = (long)drC["id_comuna"];
                    com.Nombre = (string)drC["nombre"];
                    lcom.Add(com);
                }
                cmd.Connection.Close();
                return lcom;
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

        //public RegionVO ObtenerIdRegion(string nombreRegion)
        //{
        //    SqlCommand cmd = new SqlCommand("", con.Conectar());
        //    RegionVO reg = new RegionVO();

        //    try
        //    {
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.CommandText = "sp_obtenerRegionPorNombre";
        //        cmd.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = nombreRegion;

        //        cmd.Connection.Close();
        //        cmd.Connection.Open();

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr.Read())
        //        {
        //            reg.Id_region = (long)dr["id_region"];
        //        }
        //        cmd.Connection.Close();
        //        return reg;
        //    }
        //    catch (Exception)
        //    {
        //        if (cmd.Connection.State == System.Data.ConnectionState.Open)
        //        {
        //            cmd.Connection.Close();
        //        }
        //        throw;
        //    }
        //}
    }
}
