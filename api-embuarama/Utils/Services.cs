using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace api_embuarama.Utils
{
    public class Services
    {
        public string CriptografarSenha(string senha)
        {
            string hash = "";

            using (SHA1 sha1Hash = SHA1.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            }

            return hash;
        }

        public string GerarTokenEmpresa()
        {
            string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            string dsTokenEmpresa = String.Empty;
            char[] chars = new char[6];
            Random rd = new Random();
            for (int i = 0; i < 6; i++)
            {
                chars[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
            }
            dsTokenEmpresa = "EMBU_" + new string(chars);
            return dsTokenEmpresa;
        }
    }

}
