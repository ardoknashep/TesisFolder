using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class UsuarioVO
    {
        private int _rut;
        private char _dv;
        private string _nombre, _apellido_p, _apellido_m, _email, _userName;
        private byte[] _passwd;        
        private CargoVO _cargo;
        private RolVO _rol;
       
        public int Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        
        public char Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value.ToUpper(); }
        }

        public string Apellido_p
        {
            get { return _apellido_p; }
            set { _apellido_p = value.ToUpper(); }
        }

        public string Apellido_m
        {
            get { return _apellido_m; }
            set { _apellido_m = value.ToUpper(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public byte[] Passwd
        {
            get { return _passwd; }
            set { _passwd = value; }
        }

        public CargoVO Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public RolVO Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public UsuarioVO()
        {
            this.Init();
        }

        private void Init()
        {
            _rut= 0;
            _dv = '0';
            _nombre = string.Empty;
            _apellido_p = string.Empty;
            _apellido_m = string.Empty;
            _email = string.Empty;
            _userName = string.Empty;
            _passwd = new byte[0];
            _cargo = new CargoVO();
            _rol = new RolVO();
        }

    }
}
