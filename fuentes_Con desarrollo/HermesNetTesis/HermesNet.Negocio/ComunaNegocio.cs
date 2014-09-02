using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.DAO;
using HermesNet.Model;

namespace HermesNet.Negocio
{
    public class ComunaNegocio
    {
        private ComunaDAO cDAO;

        public ComunaNegocio()
        {
            cDAO = new ComunaDAO();
        }

        public List<ComunaVO> ObtenerComunas(long idReg)
        {
            try
            {
                return cDAO.ObtenerComuna(idReg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public RegionVO ObtenerIdRegion(string region)
        //{
        //    try
        //    {
        //        return cDAO.ObtenerIdRegion(region);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
