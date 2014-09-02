using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class TipoCuentaVO
    {
        private long _idTipoCuenta;
        private string _descripcion;

        public long IdTipoCuenta
        {
            get { return _idTipoCuenta; }
            set { _idTipoCuenta = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public TipoCuentaVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idTipoCuenta = 0;
            _descripcion = string.Empty;
        }
    }
}
