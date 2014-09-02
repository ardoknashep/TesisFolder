using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.DAO;
using HermesNet.Model;

namespace HermesNet.Negocio
{
    public class AseguradoraNegocio
    {
        private AseguradoraDAO aDAO;
        public AseguradoraNegocio()
        {
            aDAO = new AseguradoraDAO();
        }

        public AseguradoraVO AseguradoraPorRut(long rut, char dv)
        {
            try
            {
                return aDAO.ObtenerAseguradoraPorRut(rut, dv);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<AseguradoraVO> AseguradoraPorRazonSocial(string razonSocial)
        {
            try
            {
                return aDAO.ObtenerAseguradoraPorRazonSocial(razonSocial);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
