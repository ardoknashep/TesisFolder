using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.Model;
using HermesNet.DAO;

namespace HermesNet.Negocio
{
    public class CargoNegocio
    {
        public CargoNegocio()
        {
        }

        /// <summary>
        /// Obtiene todos los cargos desde la base de datos
        /// </summary>
        /// <returns></returns>
        public List<CargoVO> ObtenerTodosLosCargos()
        {
            List<CargoVO> lcvo = new List<CargoVO>();
            try
            {
                CargoDAO cdao = new CargoDAO();
                lcvo = cdao.ObtenerTodosLosCargos();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return lcvo;
        }
    }
}
