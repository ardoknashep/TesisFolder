using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class BancoVO
    {
        private long _idBanco;
        private string _descripcion;

        public long IdBanco
        {
            get { return _idBanco; }
            set { _idBanco = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public BancoVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idBanco = 0;
            _descripcion = string.Empty;
        }
    }
}
