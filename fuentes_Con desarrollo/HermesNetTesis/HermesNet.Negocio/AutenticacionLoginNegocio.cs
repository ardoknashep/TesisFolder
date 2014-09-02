using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace HermesNet.Negocio
{
    public class AutenticacionLoginNegocio
    {
        const string CONTAINER_NAME = "ContenedorRSA";
        public static RSACryptoServiceProvider rsa;

        public AutenticacionLoginNegocio()
        {
        }

        public string GenerarFirmaEncriptada(string user, string passwd)
        {
            string respuesta = string.Empty;
            string textoACifrar = string.Format("{0}|{1}", user, passwd);
            try
            {
                CspParameters cspParams;
                cspParams = new CspParameters(1);	// PROV_RSA_FULL
                cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
                cspParams.KeyContainerName = CONTAINER_NAME;

                // Instanciar el algoritmo de cifrado RSA
                rsa = new RSACryptoServiceProvider(cspParams);

                StreamReader reader1 = new StreamReader(@"C:\\Llaves\llave_publica.xml");
                string publicOnlyKeyXML = reader1.ReadToEnd();
                rsa.FromXmlString(publicOnlyKeyXML);
                reader1.Close();

                // Convertir el texto a cifrar (plano) a su representación en bytse
                byte[] textoPlanoBytes = System.Text.Encoding.UTF8.GetBytes(textoACifrar);

                // Realizar el proceso de cifrado
                byte[] textoCifradoBytes = rsa.Encrypt(textoPlanoBytes, false);

                // Convertir el mensaje cifrado a su representación en cadena
                string MensajeCifrado = Convert.ToBase64String(textoCifradoBytes);

                respuesta = MensajeCifrado;

            }
            catch (Exception)
            {
                
                throw;
            }
            return respuesta;
        }

        /// <summary>
        /// Cifra un rut para el envío de actualizacion de pass al web service
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public string GenerarFirmaEncriptadaReenvioPass(long rut)
        {
            string respuesta = string.Empty;
            string textoACifrar = string.Format("{0}", rut);
            try
            {
                CspParameters cspParams;
                cspParams = new CspParameters(1);	// PROV_RSA_FULL
                cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
                cspParams.KeyContainerName = CONTAINER_NAME;

                // Instanciar el algoritmo de cifrado RSA
                rsa = new RSACryptoServiceProvider(cspParams);

                StreamReader reader1 = new StreamReader(@"C:\\Llaves\llave_publica.xml");
                string publicOnlyKeyXML = reader1.ReadToEnd();
                rsa.FromXmlString(publicOnlyKeyXML);
                reader1.Close();

                // Convertir el texto a cifrar (plano) a su representación en bytse
                byte[] textoPlanoBytes = System.Text.Encoding.UTF8.GetBytes(textoACifrar);

                // Realizar el proceso de cifrado
                byte[] textoCifradoBytes = rsa.Encrypt(textoPlanoBytes, false);

                // Convertir el mensaje cifrado a su representación en cadena
                string MensajeCifrado = Convert.ToBase64String(textoCifradoBytes);

                respuesta = MensajeCifrado;

            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }


    }
}
