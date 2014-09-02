using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class CargoVO
    {
        private long _id_cargo;        
        private string _descripcion;

        public long Id_cargo
        {
            get { return _id_cargo; }
            set { _id_cargo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public CargoVO()
        {
            this.Init();
        }

        private void Init()
        {
            _descripcion = string.Empty;
            _id_cargo = 0;
        }
    }
}
