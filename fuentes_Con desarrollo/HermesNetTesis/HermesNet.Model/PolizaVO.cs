using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class PolizaVO
    {
        private long _idpoliza, _numeroPoliza;
        private bool _blnUtilizaEmpresaPoliza, _blnVigente;
        private DateTime _fechaInicioVigencia, _fechaFinVigencia;
        private EmpresaFilialVO _empresaFilial;
        private AseguradoraVO _aseguradora;
        private EmpresaPolizaVO _empresaPoliza;

        public long IdPoliza
        {
            get { return _idpoliza; }
            set { _idpoliza = value; }
        }
        public long NumeroPoliza
        {
            get { return _numeroPoliza; }
            set { _numeroPoliza = value; }
        }
        public bool BlnUtilizaEmpresaPoliza
        {
            get { return _blnUtilizaEmpresaPoliza; }
            set { _blnUtilizaEmpresaPoliza = value; }
        }
        public bool BlnVigente
        {
            get { return _blnVigente; }
            set { _blnVigente = value; }
        }
        public DateTime FechaInicioVigencia
        {
            get { return _fechaInicioVigencia; }
            set { _fechaInicioVigencia = value; }
        }
        public DateTime FechaFinVigencia
        {
            get { return _fechaFinVigencia; }
            set { _fechaFinVigencia = value; }
        }
        public EmpresaFilialVO EmpresaFilial
        {
            get { return _empresaFilial; }
            set { _empresaFilial = value; }
        }
        public EmpresaPolizaVO EmpresaPoliza
        {
            get { return _empresaPoliza; }
            set { _empresaPoliza = value; }
        }
        public AseguradoraVO Aseguradora
        {
            get { return _aseguradora; }
            set { _aseguradora = value; }
        }

        public PolizaVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idpoliza = 0;
            _numeroPoliza = 0;
            _blnUtilizaEmpresaPoliza = false;
            _blnVigente = false;
            _fechaInicioVigencia = new DateTime();
            _fechaFinVigencia = new DateTime();
            _empresaFilial = new EmpresaFilialVO();
            _aseguradora = new AseguradoraVO();
            _empresaPoliza = new EmpresaPolizaVO();
        }
    }
}
