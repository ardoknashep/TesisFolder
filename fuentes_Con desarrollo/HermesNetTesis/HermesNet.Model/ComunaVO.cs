using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class ComunaVO
    {
        private long _id_comuna;
        private string _nombre;
        private RegionVO _region;

        public long Id_comuna
        {
            get { return _id_comuna; }
            set { _id_comuna = value; }
        }        

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public RegionVO Region
        {
            get { return _region; }
            set { _region = value; }
        }

        public ComunaVO()
        {
            this.Init();
        }

        private void Init()
        {
            _id_comuna = 0;
            _nombre = string.Empty;
            _region = new RegionVO();
        }
    }
}
