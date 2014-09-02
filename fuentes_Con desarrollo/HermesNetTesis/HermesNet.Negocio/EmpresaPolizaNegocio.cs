using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.DAO;
using HermesNet.Model;

namespace HermesNet.Negocio
{
    public class EmpresaPolizaNegocio
    {
        private EmpresaPolizaDAO emPDAO;

        public EmpresaPolizaNegocio()
        {
            emPDAO = new EmpresaPolizaDAO();
        }

        public EmpresaPolizaVO BuscarEmpPolizaPorRut(long rut, char dv)
        {
            try
            {
                return emPDAO.BuscarRutEP(rut,dv);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int CrearEmpresaPoliza(long rut, char dv, string razonSocial, string direccion, long idComuna, string telefono, string email)
        {
            try
            {
                return emPDAO.CrearEmpresaPoliza(rut,dv,razonSocial,direccion,idComuna,telefono,email);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EmpresaPolizaVO> ObtenerEmpPolizaPorRazonSocial(string razonSocial)
        {
            try
            {
                return emPDAO.ObtenerEmpPolizaPorRazonSocial(razonSocial);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
