using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormLoginController
    {
        

        static public bool Authenticate(string username, string password, out string message)
        // Autentica um utilizador verificando username e password na db e define a sessão atual caso seja válido.
        {
            message = "";

            if (username.Trim() == "" || password.Trim() == "")
            {
                message = "Username e password não podem ser vazias";
                return false;

            }

            using (iShoppingContext context = new iShoppingContext()) { 
                Utilizador user = context.Utilizadores.Where(u => u.Username == username).FirstOrDefault();
                
                if (user == null)
                {
                    message = "Username ou Password incorretos";
                    return false;
                }

                string[] parts = user.Password.Split(':');
                byte[] salt = Convert.FromBase64String(parts[0]);
                byte[] hashStored = Convert.FromBase64String(parts[1]);

                byte[] hash = GenerateSaltedHash(password, salt);

                if (!hash.SequenceEqual(hashStored))
                {
                    message = "Username ou Password incorretos";
                    return false;
                }

                Sessao.UtilizadorAtual = user;
                message = "Autenticação bem sucedida";
            }

            return true;
        }

        private static byte[] GenerateSaltedHash(string plainText, byte[] salt)
        {
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(plainText, salt, 5000);
            return rfc2898.GetBytes(32);
        }
    }
}
/*

Como o projeto foi criado sem a encriptação, tive que fazer esse código para converter a senha em hash,
vamos supor que a senha do admin é admin, o código vai verificar se nele tem o ":" caso não tenha,
o código irá converter a senha "admin" para uma hash, fiz isso porque deixei o hash pro final.


private static byte[] GenerateSalt(int size)
{
    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    byte[] buff = new byte[size];
    rng.GetBytes(buff);
    return buff;
}


if (!user.Password.Contains(":"))
{
    if (user.Password != password)
    {
        message = "Username ou Password incorretos";
        return false;
    }

    byte[] saltNovo = GenerateSalt(8);
    byte[] hashNovo = GenerateSaltedHash(password, saltNovo);
    user.Password = Convert.ToBase64String(saltNovo) + ":" + Convert.ToBase64String(hashNovo);
    context.SaveChanges();
}
else
{
    string[] parts = user.Password.Split(':');
    byte[] salt = Convert.FromBase64String(parts[0]);
    byte[] hashStored = Convert.FromBase64String(parts[1]);

    byte[] hash = GenerateSaltedHash(password, salt);

    if (!hash.SequenceEqual(hashStored))
    {
        message = "Username ou Password incorretos";
        return false;
    }
}
*/