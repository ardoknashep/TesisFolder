using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class SolicitudVO
    {
        private long _idSolicitud;
        private DateTime _fechaRealizacionSolicitud, _fechaCambioEstadoSolicitud;
        private UsuarioVO _usuario;
        private PolizaVO _poliza;
        private TipoSolicitudVO _tipoSolicitud;
        private EstadoSolicitudVO _estadoSolicitud;

        public long IdSolicitud
        {
            get { return _idSolicitud; }
            set { _idSolicitud = value; }
        }
        public DateTime FechaRealizacionSolicitud
        {
            get { return _fechaRealizacionSolicitud; }
            set { _fechaRealizacionSolicitud = value; }
        }
        public DateTime FechaCambioEstadoSolicitud
        {
            get { return _fechaCambioEstadoSolicitud; }
            set { _fechaCambioEstadoSolicitud = value; }
        }
        public UsuarioVO Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public PolizaVO Poliza
        {
            get { return _poliza; }
            set { _poliza = value; }
        }
        public TipoSolicitudVO TipoSolicitud
        {
            get { return _tipoSolicitud; }
            set { _tipoSolicitud = value; }
        }
        public EstadoSolicitudVO EstadoSolicitud
        {
            get { return _estadoSolicitud; }
            set { _estadoSolicitud = value; }
        }

        public SolicitudVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idSolicitud = 0;
            _fechaRealizacionSolicitud = new DateTime();
            _fechaCambioEstadoSolicitud = new DateTime();
            _usuario = new UsuarioVO();
            _poliza = new PolizaVO();
            _tipoSolicitud = new TipoSolicitudVO();
            _estadoSolicitud = new EstadoSolicitudVO();
        }
    }
}
