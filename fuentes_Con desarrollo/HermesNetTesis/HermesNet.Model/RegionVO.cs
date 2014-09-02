using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    //[Serializable]
    public class RegionVO
    {
        private long _id_region;
        private string _descripcion;

        public long Id_region
        {
            get { return _id_region; }
            set { _id_region = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public RegionVO()
        {
            this.Init();
        }

        private void Init()
        {
            _id_region = 0;
            _descripcion = string.Empty;
        }

    }
}
