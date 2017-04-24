using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace Projeto.Util
{
    public class Criptografia
    {

        //método para receber uma senha e retorna-la em MD5
        public string EncriptarSenha(string senha)
        {
            //converter a senha para valor em bytes..
            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);
            
            //realizar a criptografia..
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(senhaBytes);
            string resultado = string.Empty;

            foreach (byte b in hash)
            {
                resultado += b.ToString("X"); //hexadecimal..
            }

            return resultado; //retornando..
        }
    }
}
