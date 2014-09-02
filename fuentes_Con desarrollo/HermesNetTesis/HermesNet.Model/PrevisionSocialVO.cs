using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class PrevisionSocialVO
    {
        private long _idPrevisionSocial;
        private string _descripcion;

        public long IdPrevisionSocial
        {
            get { return _idPrevisionSocial; }
            set { _idPrevisionSocial = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public PrevisionSocialVO()
        {
            this.Init();
        }

        private void Init()
        {
            _idPrevisionSocial = 0;
            _descripcion = string.Empty;
        }
    }
}
