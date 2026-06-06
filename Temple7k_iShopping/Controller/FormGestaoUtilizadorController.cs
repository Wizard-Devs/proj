using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoUtilizadorController
    {
        public static List<Utilizador> ObterUtilizadores()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Utilizadores.ToList();
            }
        }

        static public bool AdicionarUtilizador(string userName, string password, string confirmPassword, out string message)
        {
            message = "";

            if(userName == "" || password == "" || confirmPassword == "")
            {
                message = "Todos campos precisam ser preenchidos";
                return false;
            }

            if (password != confirmPassword)
            {
                message = "As passwords devem ser iguais";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                bool userRepetido = db.Utilizadores.Any(U =>
                    U.Username == userName
                );

                if (userRepetido)
                {
                    message = "Esse usuário já existe na base de dados.";
                    return false;
                }

                Utilizador user = new Utilizador
                {
                    Username = userName,
                    Password = password,
                };

                db.Utilizadores.Add(user);
                db.SaveChanges();

                message = "Utilizador guardado com sucesso";
                return true;
            }

        }

        static public bool AlterarUtilizador(int id, string userName, string password, string confirmPassword, out string message)
        {
            message = "";

            if (userName == "" || password == "" || confirmPassword == "")
            {
                message = "Todos campos precisam ser preenchidos";
                return false;
            }

            if (password != confirmPassword)
            {
                message = "As passwords devem ser iguais";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Utilizador user = db.Utilizadores.Find(id);

                if (user == null)
                {
                    message = "Não existe nenhum utilizador com este ID";
                    return false;
                }

                bool repetido = db.Utilizadores.Any(U =>
                    U.Username == userName &&
                    U.Id != id
                );

                if (repetido)
                {
                    message = "Já existe outro utilizador com os mesmos dados";
                    return false;
                }

                user.Username = userName;
                user.Password = password;

                db.SaveChanges();

                message = "Utilizador atualizado com sucesso!";
                return true;
            }
        }

        public static bool RemoverUtilizador(int id, out string message)
        {
            message = "";

            using (iShoppingContext db = new iShoppingContext())
            {
                Utilizador user = db.Utilizadores.Find(id);

                if (user == null)
                {
                    message = "Não existe nenhum tipo de utilizador com esse ID";
                    return false;
                }

                if(id == Sessao.UtilizadorAtual.Id)
                {
                    message = "O utilizador não pode se deletar";
                    return false;
                }

                db.Utilizadores.Remove(user);
                db.SaveChanges();

                message = "Tipo de utilizador eliminado com sucesso";
                return true;
            }
        }
    }
}
