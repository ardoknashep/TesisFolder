using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class TipoSeguroVO
    {
        private long _idTipoSeguro;
        private string _descripcion;

        public long IdTipoSeguro
        {
            get { return _idTipoSeguro; }
            set { _idTipoSeguro = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public TipoSeguroVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idTipoSeguro = 0;
            _descripcion = string.Empty;
        }

    }
}
