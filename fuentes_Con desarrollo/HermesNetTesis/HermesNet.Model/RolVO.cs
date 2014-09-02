using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class RolVO
    {
        private long _idRol;
        private string _descripcion;

        public long IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public RolVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idRol = 0;
            _descripcion = string.Empty;
        }
    }
}
