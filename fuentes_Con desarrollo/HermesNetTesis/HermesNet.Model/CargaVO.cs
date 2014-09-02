using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class CargaVO
    {
        private long _rut;
        private char _dv, _genero;
        private string _nombre, _apellidoP, _apellidoM;
        private DateTime _fechaNacimiento;
        private ParentescoVO _parentesco;

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
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public ParentescoVO Parentesco
        {
            get { return _parentesco; }
            set { _parentesco = value; }
        }

        public CargaVO()
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
            _fechaNacimiento = new DateTime();
            _parentesco = new ParentescoVO();
        }
    }
}
