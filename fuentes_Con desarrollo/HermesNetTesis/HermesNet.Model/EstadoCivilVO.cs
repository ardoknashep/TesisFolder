using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class EstadoCivilVO
    {
        private long _idEstadoCivil;
        private string _descripcion;

        public long IdEstadoCivil
        {
            get { return _idEstadoCivil; }
            set { _idEstadoCivil = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public EstadoCivilVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idEstadoCivil = 0;
            _descripcion = string.Empty;
        }
    }
}
