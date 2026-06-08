using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoTipoArtigosController
    {
        public static List<TipoArtigo> ObterTiposArtigos()
        //Essa função tem um papel de pegar todos os dados presentes na db TipoArtigo.
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.ToList();
            }
        }


        static public bool AdicionarTipoArtigo(string tipoArtigo, out string message)
        // Valida e adiciona um novo tipo de artigo na base de dados, garantindo que não exista tipo de artigo duplicado.
        {
            message = "";

            if(tipoArtigo == "")
            {
                message = "Preencha todos os campos.";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                bool repetido = db.TipoArtigo.Any(T =>
                    T.Tipo == tipoArtigo
                );

                if(repetido)
                {
                    message = "Esse tipo já existe na base de dados";
                    return false;
                }

                TipoArtigo tipo = new TipoArtigo
                {
                    Tipo = tipoArtigo,
                };

                db.TipoArtigo.Add( tipo );
                db.SaveChanges();

                message = "Tipo de Artigo guardado com sucesso";
                return true;
            }
        }

        public static bool RemoverTipoArtigo(int id, out string message)
        // Remove um tipo de artigo da base de dados com base no ID, caso ele exista.
        {
            message = "";

            using (iShoppingContext db = new iShoppingContext())
            {
                TipoArtigo tipoArt = db.TipoArtigo.Find(id);

                if(tipoArt == null)
                {
                    message = "Não existe nenhum tipo de artigo com esse ID";
                    return false;
                }

                db.TipoArtigo.Remove(tipoArt);
                db.SaveChanges();

                message = "Tipo de artigo eliminado com sucesso";
                return true;
            }
        }

        public static bool AtualizarTipo(int id, string tipo, out string message)
        // Valida e atualiza o tipo de artigo, garantindo que não exista duplicação e que o ID seja válido.
        {
            message = "";

            if (tipo.Trim() == "")
            {
                message = "Preencha todos os campos";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                TipoArtigo tipoArt = db.TipoArtigo.Find(id);

                if (tipoArt == null)
                {
                    message = "Não existe nenhum artigo com este ID";
                    return false;
                }

                bool repetido = db.TipoArtigo.Any(t =>
                    t.Tipo == tipo &&
                    t.Id != id
                );

                if (repetido)
                {
                    message = "Já existe outro artigo com os mesmos dados";
                    return false;
                }

                tipoArt.Tipo = tipo;

                db.SaveChanges();

                message = "Tipo de artigo atualizado com sucesso";
                return true;
            }
        }
    }
}
