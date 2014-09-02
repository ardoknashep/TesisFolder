using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class ParentescoVO
    {
        private long _idParentesco;
        private string _descripcion;

        public long IdParentesco
        {
            get { return _idParentesco; }
            set { _idParentesco = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public ParentescoVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idParentesco = 0;
            _descripcion = string.Empty;
        }
    }
}
