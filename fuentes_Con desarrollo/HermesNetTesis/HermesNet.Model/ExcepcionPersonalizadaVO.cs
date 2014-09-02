using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Model
{
    public class ExcepcionPersonalizadaVO : Exception
    {
        private string _clase;

        public string Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }

        public ExcepcionPersonalizadaVO(string clase, string mensaje)
            : base(mensaje)
        {
            this._clase = clase; 
        }
    }
}
