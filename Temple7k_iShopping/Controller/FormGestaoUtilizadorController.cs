using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;
using System.Security.Cryptography; // da matéria que nos foi dado de tópicos de segurança

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoUtilizadorController
    {
        

        private const int SALT_SIZE = 8; // <--- tamanho do salt em bytes
        private const int NUMBER_OF_ITERATIONS = 5000; // <--- cada tentativa de adivinhar a password tem que repetir o calculo 5000 vezes tornando ataques de brute force mais lento

        private static byte[] GenerateSalt(int size)
        // Gera um salt aleatório pra ninguém conseguir "adivinhar" a password mesmo que tenha acesso à base de dados
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return buff;
        }

        private static byte[] GenerateSaltedHash(string plainText, byte[] salt)
        // mistura a password com o salt 5000 vezes pra gerar um hash que é praticamente impossível de reverter
        {
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(plainText, salt, NUMBER_OF_ITERATIONS);
            return rfc2898.GetBytes(32);
        }

        public static List<Utilizador> ObterUtilizadores()
        //Essa função tem um papel de pegar todos os dados presentes na db Utilizador.
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Utilizadores.ToList();
            }
        }



        static public bool AdicionarUtilizador(string userName, string password, string confirmPassword, out string message)
        // Valida os dados e adiciona um novo utilizador na db, garantindo que o username não seja duplicado e que as passwords sejam semelhantes.
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

                byte[] salt = GenerateSalt(SALT_SIZE); // gera um salt aleatório único para este utilizador
                byte[] hash = GenerateSaltedHash(password, salt); // combina a password com o salt e gera o hash

                string saltBase64 = Convert.ToBase64String(salt); // converte os bytes do salt para string legível em Base64
                string hashBase64 = Convert.ToBase64String(hash); // converte os bytes do hash para string legível em Base64
                string passwordStored = saltBase64 + ":" + hashBase64; // une os dois separados por ":" para guardar num unico campo

                Utilizador user = new Utilizador
                {
                    Username = userName,
                    Password = passwordStored,
                };

                db.Utilizadores.Add(user);
                db.SaveChanges();

                message = "Utilizador guardado com sucesso";
                return true;
            }

        }

        static public bool AlterarUtilizador(int id, string userName, string password, string confirmPassword, out string message)
        // Valida e atualiza os dados de um utilizador, garantindo que o username não é duplicado e que as passwords sejam semelhantes.
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

                byte[] salt = GenerateSalt(SALT_SIZE); // gera um novo salt aleatório (ele nunca irá reutilizar o salt antigo), se a password for igual o hash será diferente
                byte[] hash = GenerateSaltedHash(password, salt); // recalcula o hash com a nova password e o novo salt

                string saltBase64 = Convert.ToBase64String(salt);
                string hashBase64 = Convert.ToBase64String(hash);

                user.Username = userName;
                user.Password = saltBase64 + ":" + hashBase64; // troca a password antiga pelo novo "salt:hash"

                db.SaveChanges();

                message = "Utilizador atualizado com sucesso!";
                return true;
            }
        }

        public static bool RemoverUtilizador(int id, out string message)
        // Remove um utilizador da base de dados pelo ID, impedindo que o utilizador atual se elimine.
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
