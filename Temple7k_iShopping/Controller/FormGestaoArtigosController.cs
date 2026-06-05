using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoArtigosController
    {
        public static List<Artigo> ObterArtigos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                var artigos = db.Artigos.ToList();
                var tiposArtigo = db.TipoArtigo.ToList();

                return artigos.Join(
                    tiposArtigo,
                    artigo => artigo.TipoArtigoId,
                    tipo => tipo.Id,
                    (artigo, tipo) => new Artigo
                    {
                        Id = artigo.Id,
                        Nome = artigo.Nome,
                        TipoArtigoId = artigo.TipoArtigoId,
                        TipoArtigo = tipo.Tipo
                    }).ToList();
            }
        }

        public static bool AdicionarArtigo(string nomeArtigo, int tipoArtigoId, out string message)
        {
            message = "";

            if(nomeArtigo == "")
            {
                message = "Preencha todos os campos";
                return false;
            }

            using(iShoppingContext db = new iShoppingContext())
            {
                bool repetido = db.Artigos.Any(T =>
                    T.Nome == nomeArtigo
                );

                if(repetido)
                {
                    message = "Esse artigo ja existe na base de dados";
                    return false;
                }

                Artigo artigo = new Artigo
                {
                    Nome = nomeArtigo,
                    TipoArtigoId = tipoArtigoId,
                };

                db.Artigos.Add(artigo);
                db.SaveChanges();

                message = "Artigo guardado com sucesso";
                return true;
            }
        }

        public static bool AtualizarArtigo(int id, string nomeArtigo, int tipoArtigoId, out string message)
        {
            message = "";

            if (nomeArtigo.Trim() == "")
            {
                message = "Preencha todos os campos";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Artigo artigo = db.Artigos.Find(id);

                if (artigo == null)
                {
                    message = "Não existe nenhum artigo com este ID";
                    return false;
                }

                bool repetido = db.Artigos.Any(a =>
                    a.Nome == nomeArtigo &&
                    a.TipoArtigoId == tipoArtigoId &&
                    a.Id != id
                );

                if (repetido)
                {
                    message = "Já existe outro artigo com os mesmos dados";
                    return false;
                }

                artigo.Nome = nomeArtigo;
                artigo.TipoArtigoId = tipoArtigoId;

                db.SaveChanges();

                message = "Artigo atualizado com sucesso";
                return true;
            }
        }

        public static bool RemoverArtigo(int id, out string message)
        {
            message = "";

            using (iShoppingContext db = new iShoppingContext())
            {
                Artigo artigo = db.Artigos.Find(id);

                if (artigo == null)
                {
                    message = "Não existe nenhum artigo com esse ID";
                    return false;
                }

                db.Artigos.Remove(artigo);
                db.SaveChanges();

                message = "Artigo eliminado com sucesso";
                return true;
            }
        }
    }
}
