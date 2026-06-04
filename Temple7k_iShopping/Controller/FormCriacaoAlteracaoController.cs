using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormCriacaoAlteracaoController
    {
        public List<ItemPrevisto> Items;

        public FormCriacaoAlteracaoController() { 
            Items = new List<ItemPrevisto>();
        }

        private bool Validate(string name, out string message)
        {
            if (name.Trim() == "")
            {
                message = "O nome do planeamento de compra não pode ser vazio.";
                return false;
            }

            if (this.Items == null || this.Items.Count == 0)
            {
                message = "O planeamento deve conter pelo menos um artigo.";
                return false;
            }

            message = "";
            return true;
        }

        public static List<Artigo> GetArtigos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.ToList();
            }
        }

        public static List<TipoArtigo> GetTiposArtigos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.ToList();
            }
        }

        public bool AddItems(string quantidadePrevista, int artigoId, out string message) {
            int parsedQuantidadePrevista;

            if (!int.TryParse(quantidadePrevista, out parsedQuantidadePrevista) || parsedQuantidadePrevista <= 0)
            {
                message = "Por favor, insira uma quantidade prevista válida (número inteiro positivo).";
                return false;
            }

            this.Items.Add(new ItemPrevisto { ArtigoId = artigoId, QuantidadePrevista = parsedQuantidadePrevista });

            message = "Item adicionado com sucesso.";
            return true;
        }

        public bool Save(string name, out string message)
        {
            if (!Validate(nome, out message))
            {
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Compra compra = new Compra
                {
                    Nome = name,
                    DataInicio = DateTime.Now,
                    Fechada = false,
                    UtilizadorCriouId = Sessao.UtilizadorAtual.Id,
                    DataCriacao = DateTime.Now
                };

                db.Compras.Add(novaCompra);
                db.SaveChanges(); // salva para gerar o ID da compra

                foreach (ItemPrevisto item in itens)
                {
                    item.CompraId = novaCompra.Id;
                    item.DataCriacao = DateTime.Now;
                    item.UtilizadorCriouId = Sessao.UtilizadorAtual.Id;

                    item.QuantidadeAdquirida = 0;
                    item.PrecoUnitario = 0;

                    db.ItemPrevistos.Add(item);
                }

                db.SaveChanges();
            }

            message = "Planeamento de compra criado com sucesso.";
            return true;
        }
    }
}
