using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class EstadoSolicitudVO
    {
        private long _idEstadoSolicitud;
        private string _descripcion;

        public long IdEstadoSolicitud
        {
            get { return _idEstadoSolicitud; }
            set { _idEstadoSolicitud = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public EstadoSolicitudVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idEstadoSolicitud = 0;
            _descripcion = string.Empty;
        }
    }
}
