using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class AseguradoVO
    {
        private long _rut;
        private char _dv, _genero;
        private string _nombre, _apellidoP, _apellidoM, _telefono, _email, _numeroCuenta, _direccion;
        private DateTime _fechaNacimiento;
        private bool _blnTieneCargas;
        private ComunaVO _comuna;
        private EstadoCivilVO _estadoCivil;
        private PrevisionSocialVO _previsionSocial;
        private FormaPagoVO _formaPago;
        private BancoVO _banco;
        private TipoCuentaVO _tipoCuenta;

        public long Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        public char Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }
        public char Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string ApellidoP
        {
            get { return _apellidoP; }
            set { _apellidoP = value; }
        }
        public string ApellidoM
        {
            get { return _apellidoM; }
            set { _apellidoM = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string NumeroCuenta
        {
            get { return _numeroCuenta; }
            set { _numeroCuenta = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public bool BlnTieneCargas
        {
            get { return _blnTieneCargas; }
            set { _blnTieneCargas = value; }
        }
        public ComunaVO Comuna
        {
            get { return _comuna; }
            set { _comuna = value; }
        }
        public EstadoCivilVO EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }
        public PrevisionSocialVO PrevisionSocial
        {
            get { return _previsionSocial; }
            set { _previsionSocial = value; }
        }
        public FormaPagoVO FormaPago
        {
            get { return _formaPago; }
            set { _formaPago = value; }
        }
        public BancoVO Banco
        {
            get { return _banco; }
            set { _banco = value; }
        }
        public TipoCuentaVO TipoCuenta
        {
            get { return _tipoCuenta; }
            set { _tipoCuenta = value; }
        }

        public AseguradoVO()
        {
            this.Init();
        }

        private void Init()
        {
            _rut = 0;
            _dv = '0';
            _genero = '0';
            _nombre = string.Empty;
            _apellidoP = string.Empty;
            _apellidoM = string.Empty;
            _telefono = string.Empty;
            _email = string.Empty;
            _numeroCuenta = string.Empty;
            _direccion = string.Empty;
            _fechaNacimiento = new DateTime();
            _blnTieneCargas = false;
            _comuna = new ComunaVO();
            _estadoCivil = new EstadoCivilVO();
            _previsionSocial = new PrevisionSocialVO();
            _formaPago = new FormaPagoVO();
            _banco = new BancoVO();
            _tipoCuenta = new TipoCuentaVO();
        }
    }
}
