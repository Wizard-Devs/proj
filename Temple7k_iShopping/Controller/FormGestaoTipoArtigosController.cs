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
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.ToList();
            }
        }

        static public bool AdicionarTipoArtigo(string tipoArtigo, out string message)
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
