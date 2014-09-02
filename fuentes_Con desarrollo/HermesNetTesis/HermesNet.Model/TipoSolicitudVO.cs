using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class TipoSolicitudVO
    {
        private int _idTipoSolicitud;
        private string _descripcion;

        public int IdTipoSolicitud
        {
            get { return _idTipoSolicitud; }
            set { _idTipoSolicitud = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public TipoSolicitudVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idTipoSolicitud = 0;
            _descripcion = string.Empty;
        }
    }
}
