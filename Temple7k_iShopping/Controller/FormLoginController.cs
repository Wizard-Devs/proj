using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormLoginController
    {
        static public bool Authenticate(string username, string password, out string message)
        {
            message = "";

            if (username.Trim() == "" || password.Trim() == "")
            {
                message = "Username e password não podem ser vazias";
                return false;

            }

            using (iShoppingContext context = new iShoppingContext()) { 
                Utilizador user = context.Utilizadores.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                
                if (user == null)
                {
                    message = "Username ou Password incorretos";
                    return false;
                }

                Sessao.UtilizadorAtual = user.Username;
                message = "Autenticação bem sucedida";
            }

            return true;
        }
    }
}
