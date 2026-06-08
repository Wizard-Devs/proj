using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormCompraController
    {
        public List<ItemCompra> Items { get; private set; }
        private int compraId;

        public FormCompraController(int compraId) {
            this.compraId = compraId;

            Items = new List<ItemCompra>();

            using (iShoppingContext db = new iShoppingContext())
            {
                Items = db.ItensCompra
                    .Include("Artigo")
                    .Where(i => i.CompraId == compraId)
                    .ToList();
            }
        }

        public static List<ItemCompra> GetItems(int compraId)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.ItensCompra
                    .Include("Artigo")
                    .Where(i => i.CompraId == compraId)
                    .ToList();
            }
        }

        public static List<Artigo> GetArtigos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.ToList();
            }
        }

        public static Orcamento GetOrcamento()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                Orcamento orcamento = db.Orcamentos.FirstOrDefault(o => o.Mes == DateTime.Now.Month);
                return orcamento;
            }
        }

        public decimal GetOrcamentoDisponivel()
        {
            Orcamento orcamento = GetOrcamento();
            if (orcamento == null) return 0;

            decimal gastoAtual = this.Items.Sum(i => i.QuantidadeAdquirida * i.PrecoUnitario);
            return orcamento.Valor - gastoAtual;
        }

        private bool Validate(string quantidade, string precoUnitario, out int parsedQuantidade, out decimal parsedPrecoUnitario, out string message)
        {
            parsedQuantidade = 0;
            parsedPrecoUnitario = 0;

            if (!int.TryParse(quantidade, out parsedQuantidade) || parsedQuantidade <= 0)
            {
                message = "Por favor, insira uma quantidade válida (número inteiro positivo).";
                return false;
            }

            if (!decimal.TryParse(precoUnitario, out parsedPrecoUnitario) || parsedPrecoUnitario <= 0)
            {
                message = "Por favor, insira um preço unitário válido (número decimal positivo).";
                return false;
            }

            message = "";
            return true;
        }

        public bool AddItems(string quantidade, string precoUnitario, string observacao, int artigoId, out string message)
        {
            int parsedQuantidade = 0;
            decimal parsedPrecoUnitario = 0;

            if (!this.Validate(quantidade, precoUnitario, out parsedQuantidade, out parsedPrecoUnitario, out message)) return false;

            if (observacao.Trim() == "")
            {
                message = "Por favor, insira uma observação.";
                return false;
            }

            if (this.Items.Any(i => i.ArtigoId == artigoId))
            {
                message = "Este artigo já foi adicionado. Utilize o botão Alterar se quiser mudar a quantidade.";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Artigo artigo = db.Artigos.Find(artigoId);
                TipoArtigo tipoArtigo = db.TipoArtigo.Find(artigo.TipoArtigoId);

                this.Items.Add(new ItemNaoPrevisto
                {
                    ArtigoId = artigoId,
                    TipoArtigoId = artigo.TipoArtigoId,
                    Artigo = artigo,
                    TipoArtigo = tipoArtigo,
                    QuantidadeAdquirida = parsedQuantidade,
                    PrecoUnitario = parsedPrecoUnitario,
                    Observacao = observacao,
                    utilizadorCriouId = Sessao.UtilizadorAtual.Id,
                    DataCriacao = DateTime.Now
                });
            }

            message = "Item adicionado com sucesso.";
            return true;
        }

        public bool UpdateItem(string quantidade, string precoUnitario, string observacao, int artigoId, out string message)
        {
            int parsedQuantidade = 0;
            decimal parsedPrecoUnitario = 0;

            if (!Validate(quantidade, precoUnitario, out parsedQuantidade, out parsedPrecoUnitario, out message)) return false;

            ItemCompra item = this.Items.FirstOrDefault(i => i.ArtigoId == artigoId);

            if (item == null)
            {
                message = "Item não encontrado.";
                return false;
            }

            if (item is ItemNaoPrevisto naoPrevisto)
            {
                if (observacao.Trim() == "")
                {
                    message = "Por favor, insira uma observação.";
                    return false;
                }

                naoPrevisto.Observacao = observacao;
            }


            item.QuantidadeAdquirida = parsedQuantidade;
            item.PrecoUnitario = parsedPrecoUnitario;
            item.utilizadorAlterouId = Sessao.UtilizadorAtual.Id;
            item.DataAlteracao = DateTime.Now;
            message = "Item atualizado com sucesso.";

            return true;
        }

        public void RemoveItem(int artigoId)
        {
            this.Items.RemoveAll(i => i.ArtigoId == artigoId);
        }

        public bool CloseCompra(out string message)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                Compra compra = db.Compras.Find(this.compraId);

                if (compra == null)
                {
                    message = "Compra não encontrada.";
                    return false;
                }

                List<ItemPrevisto> itemsPrevistos = db.ItensPrevistos
                    .Where(i => i.CompraId == this.compraId)
                    .ToList();

                foreach (ItemPrevisto item in itemsPrevistos)
                {
                    ItemCompra itemExists = this.Items.FirstOrDefault(i => i.ArtigoId == item.ArtigoId);

                    if (itemExists != null)
                    {
                        item.QuantidadeAdquirida = itemExists.QuantidadeAdquirida;
                        item.PrecoUnitario = itemExists.PrecoUnitario;
                        item.utilizadorAlterouId = Sessao.UtilizadorAtual.Id;
                        item.DataAlteracao = DateTime.Now;
                    }
                }

                List<ItemNaoPrevisto> itemsNaoPrevistos = db.ItensNaoPrevistos
                    .Where(i => i.CompraId == this.compraId)
                    .ToList();

                foreach (ItemCompra item in this.Items)
                {
                    ItemNaoPrevisto itemExists = itemsNaoPrevistos.FirstOrDefault(i => i.ArtigoId == item.ArtigoId);

                    if (item is ItemNaoPrevisto naoPrevisto)
                    {
                        if (itemExists == null)
                        {
                            db.ItensNaoPrevistos.Add(new ItemNaoPrevisto
                            {
                                ArtigoId = naoPrevisto.ArtigoId,
                                CompraId = compra.Id,
                                TipoArtigoId = naoPrevisto.TipoArtigoId,
                                QuantidadeAdquirida = naoPrevisto.QuantidadeAdquirida,
                                PrecoUnitario = naoPrevisto.PrecoUnitario,
                                Observacao = naoPrevisto.Observacao,
                                utilizadorCriouId = naoPrevisto.utilizadorCriouId,
                                DataCriacao = naoPrevisto.DataCriacao
                            });
                        }
                        else
                        {
                            itemExists.QuantidadeAdquirida = item.QuantidadeAdquirida;
                            itemExists.PrecoUnitario = item.PrecoUnitario;
                            itemExists.Observacao = naoPrevisto.Observacao;
                            itemExists.utilizadorAlterouId = Sessao.UtilizadorAtual.Id;
                            itemExists.DataAlteracao = DateTime.Now;
                        }
                    }
                }

                compra.Fechada = true;
                compra.DataFechada = DateTime.Now;
                compra.utilizadorFechouId = Sessao.UtilizadorAtual.Id;

                Orcamento orcamento = db.Orcamentos.FirstOrDefault(o => o.Mes == DateTime.Now.Month);

                if (orcamento == null)
                {
                    message = "Falha ao finalizar a compra. Não foi possível obter o orçamento para o mês atual.";
                    return false;
                }

                decimal totalCompra = this.Items.Sum(i => i.QuantidadeAdquirida * i.PrecoUnitario);
                orcamento.Valor -= totalCompra;

                db.SaveChanges();
            }

            message = "Compra finalizada com sucesso.";

            return true;
        }
    }
}
