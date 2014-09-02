using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.Model;
using HermesNet.DAO;

namespace HermesNet.Negocio
{
    public class RolNegocio
    {
        public RolNegocio()
        {
        }

        /// <summary>
        /// Obtiene todos los roles de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<RolVO> ObtenerTodosLosRoles()
        {
            List<RolVO> lrvo = new List<RolVO>();
            try
            {
                RolDAO rdao = new RolDAO();
                lrvo = rdao.ObtenerTodosLosRoles();
            }
            catch (Exception)
            {
                
                throw;
            }
            return lrvo;
        }
    }
}
