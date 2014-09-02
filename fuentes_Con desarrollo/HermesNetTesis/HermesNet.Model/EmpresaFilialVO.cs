using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class EmpresaFilialVO
    {
        private long _rut;
        private char _dv;
        private string _razonSocial, _direccion, _telefono, _email;
        private EmpresaContratanteVO _empresaContratante;
        private ComunaVO _comuna;

        public long Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public char Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public EmpresaContratanteVO EmpresaContratante
        {
            get { return _empresaContratante; }
            set { _empresaContratante = value; }
        }

        public ComunaVO Comuna
        {
            get { return _comuna; }
            set { _comuna = value; }
        }

        public EmpresaFilialVO()
        {
            this.Init();
        }

        private void Init()
        {
            _rut = 0;
            _dv = '0';
            _razonSocial = string.Empty;
            _direccion = string.Empty;
            _telefono = string.Empty;
            _email = string.Empty;
            _empresaContratante = new EmpresaContratanteVO();
            _comuna = new ComunaVO();
        }
    }
}
