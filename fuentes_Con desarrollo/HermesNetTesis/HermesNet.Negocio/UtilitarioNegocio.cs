using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HermesNet.Negocio
{
    public class UtilitarioNegocio
    {
        public bool ValidarRut(string rut)
        {
            bool validar = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
                if (rutAux == 1 && dv == '9')
                {
                    validar = false;
                }
                else
                {
                    int m = 0, s = 1;
                    for (; rutAux != 0; rutAux /= 10)
                    {
                        s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                    }
                    if (dv == (char)(s != 0 ? s + 47 : 75))
                    {
                        validar = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return validar;
        }
    }
}
