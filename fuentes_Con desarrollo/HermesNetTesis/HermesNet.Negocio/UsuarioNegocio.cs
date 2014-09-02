using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HermesNet.DAO;
using HermesNet.Model;

namespace HermesNet.Negocio
{
    public class UsuarioNegocio
    {
        //private UsuarioDAO _udao;
        public UsuarioNegocio()
        {
            //_udao = new UsuarioDAO();
        }

        public UsuarioVO ObtenerUsuarioByRut(string username, int rut)
        {
            UsuarioVO uvo = new UsuarioVO();
            UsuarioDAO _udao = new UsuarioDAO();
            try
            {
                uvo = _udao.ObtenerUsuarioByRut(username, rut);
            }
            catch (Exception)
            {
                
                throw;
            }
            return uvo;
        }

        public List<UsuarioVO> ObtenerTodosLosUsuarios(string username)
        {
            UsuarioDAO udao = new UsuarioDAO();
            List<UsuarioVO> luvo = new List<UsuarioVO>();
            try
            {
                luvo = udao.ObtenerTodosLosUsuarios(username);
            }
            catch (Exception)
            {
                
                throw;
            }
            return luvo;
        }

    }
}
