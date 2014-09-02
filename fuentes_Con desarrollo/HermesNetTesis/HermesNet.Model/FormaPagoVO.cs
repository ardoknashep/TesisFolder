using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class FormaPagoVO
    {
        private long _idFormaPago;
        private string _descripcion;

        public long IdFormaPago
        {
            get { return _idFormaPago; }
            set { _idFormaPago = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public FormaPagoVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idFormaPago = 0;
            _descripcion = string.Empty;
        }
    }
}
