using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class TipoDocumentoVO
    {
        private long _idTipoDocumento;
        private string _descripcion;
        private bool _blnPoseeMonto;

        public long IdTipoDocumento
        {
            get { return _idTipoDocumento; }
            set { _idTipoDocumento = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public bool BlnPoseeMonto
        {
            get { return _blnPoseeMonto; }
            set { _blnPoseeMonto = value; }
        }

        public TipoDocumentoVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idTipoDocumento = 0;
            _descripcion = string.Empty;
            _blnPoseeMonto = false;
        }

    }
}
