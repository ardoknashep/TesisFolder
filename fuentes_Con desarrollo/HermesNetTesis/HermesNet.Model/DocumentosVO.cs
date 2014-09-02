using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class DocumentosVO
    {
        private long _idDcoumento;
        private string _descripcion;
        private TipoDocumentoVO _tipoDocumento;
        private AseguradoraVO _aseguradora;

        public long IdDcoumento
        {
            get { return _idDcoumento; }
            set { _idDcoumento = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public TipoDocumentoVO TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }
        public AseguradoraVO Aseguradora
        {
            get { return _aseguradora; }
            set { _aseguradora = value; }
        }

        public DocumentosVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idDcoumento = 0;
            _descripcion = string.Empty;
            _tipoDocumento = new TipoDocumentoVO();
            _aseguradora = new AseguradoraVO();
        }
    }
}
