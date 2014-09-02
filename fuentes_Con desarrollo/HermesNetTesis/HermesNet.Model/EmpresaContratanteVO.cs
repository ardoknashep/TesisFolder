using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class EmpresaContratanteVO
    {
        private long _rut;
        private char _dv;
        private string _razon_social, _direccion, _telefono, _email;
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

        public string Razon_social
        {
            get { return _razon_social; }
            set { _razon_social = value; }
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

        public ComunaVO Comuna
        {
            get { return _comuna; }
            set { _comuna = value; }
        }

        public EmpresaContratanteVO()
        {
            this.Init();
        }

        private void Init()
        {
            _rut = 0;
            _dv = '0';
            _razon_social = string.Empty;
            _direccion = string.Empty;
            _telefono = string.Empty;
            _email = string.Empty;
            _comuna = new ComunaVO();
        }
    }
}
