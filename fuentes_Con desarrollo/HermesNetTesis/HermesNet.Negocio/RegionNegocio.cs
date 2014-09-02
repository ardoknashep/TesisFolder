using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.DAO;
using HermesNet.Model;

namespace HermesNet.Negocio
{
    public class RegionNegocio
    {
        private RegionDAO rDAO;

        public RegionNegocio()
        {
            rDAO = new RegionDAO();
        }

        public List<RegionVO> ObtenerRegiones()
        {
            try
            {
                return rDAO.ObtenerRegiones();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
