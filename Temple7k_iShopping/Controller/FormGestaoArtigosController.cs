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
        // Retorna todos os artigos com o nome do tipo de artigo correspondente
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

            //Nesta função utilizamos o join para associar o nome do TipoArtigo a cada artigo, uma vez que o modelo Artigo apenas guarda o TipoArtigoId
            /*
                                                        
                                                        Com join
                  Sem join                   ┌───────┬──────────┬──────────────┐
            ┌───────┬───────────┐            │       │          │              │
            │  ID   │  Nome     │            │   ID  │  Nome    │ TipoArtigo   │
            │       │           │            │       │          │              │
            │  1    │   Leite   │            │   1   │  Leite   │  Laticínios  │
            │       │           │ ────────>  │       │          │              │
            │       │           │            │       │          │              │
            │  2    │   Shampoo │            │   2   │  Shampoo │  Higiene     │
            │       │           │            │       │          │              │
            └───────┴───────────┘            └───────┴──────────┴──────────────┘

            Site utilizado para fazer este diagrama (https://asciiflow.com/#/)

            */
        }

        public static List<Artigo> ObterArtigosPorTipo(int tipoId)
        // Busca os artigos do tipo selecionado e junta o nome do tipo a cada artigo através do Join
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                var artigos = db.Artigos.Where(a => a.TipoArtigoId == tipoId).ToList();
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

            // Nesta função filtramos os artigos pelo tipo selecionado e utilizamos o Join para associar o nome do TipoArtigo a cada artigo, igual como foi feito na função ObterArtigos();
            /*
            ┌──────┬────────┬───────┐   ┌───────┬────────────────┐
            │      │        │       │   │       │                │
            │  Id  │  Nome  │ TipoID│   │  Id   │      Tipo      │
            │      │        │       │   │       │                │
            │      │        │       │ + │       │                │
            │   1  │  Leite │   2   │   │   2   │     Laticinios │
            │      │        │       │   │       │                │
            └──────┴────────┴───────┘   └───────┴────────────────┘
                                      │                           
                                      │                           
                                      │                           
                                      v                           
            ┌───────┬───────────┬─────────────┬──────────────────┐
            │       │           │             │                  │
            │   Id  │   Nome    │  TipoID     │   TipoArtigo     │
            │       │           │             │                  │
            │       │           │             │                  │
            │   1   │   Leite   │     2       │     Laticinios   │
            │       │           │             │                  │
            └───────┴───────────┴─────────────┴──────────────────┘
            */
        }

        public static bool AdicionarArtigo(string nomeArtigo, int tipoArtigoId, out string message)
        // Adiciona um novo artigo na base de dados, validando se o nome não está vazio e se já não existe
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
        // Atualiza os dados de um artigo existente, validando se o nome não está vazio e se já não existe outro artigo com os mesmos dados
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
        // Remove um artigo da base de dados com base no seu ID
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
