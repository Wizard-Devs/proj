using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormCriacaoAlteracaoController
    {
        public List<ItemPrevisto> Items { get; private set; }
        public int CompraId { get; private set; }
        public bool isClosed { get; private set; }

        public FormCriacaoAlteracaoController(int compraId) { 
            Items = new List<ItemPrevisto>();
            this.CompraId = compraId;
            
            if (compraId > 0)
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    Compra compra = db.Compras.Find(compraId);
                    if (compra != null)
                    {
                        this.isClosed = compra.Fechada;
                        this.Items = db.ItensPrevistos
                            .Include("Artigo")
                            .Include("TipoArtigo")
                            .Where(i => i.CompraId == compraId).ToList();
                    }
                }
            }

        }

        private bool IsCompraFechada(out string message)
        {
            if (this.isClosed)
            {
                message = "Esta compra está fechada e não pode ser alterada.";
                return true;
            }

            message = "";
            return false;
        }

        private bool Validate(string name, out string message)
        {
            if (name.Trim() == "" && this.CompraId == 0)
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

            if (this.IsCompraFechada(out message)) return false;

            if (!int.TryParse(quantidadePrevista, out parsedQuantidadePrevista) || parsedQuantidadePrevista <= 0)
            {
                message = "Por favor, insira uma quantidade prevista válida (número inteiro positivo).";
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

                this.Items.Add(new ItemPrevisto
                {
                    ArtigoId = artigoId,
                    TipoArtigoId = artigo.TipoArtigoId,
                    Artigo = artigo,
                    TipoArtigo = tipoArtigo,
                    QuantidadePrevista = parsedQuantidadePrevista,
                    utilizadorCriouId = Sessao.UtilizadorAtual.Id,
                    DataCriacao = DateTime.Now
                });
            }

            message = "Item adicionado com sucesso.";
            return true;
        }

        public bool RemoveItem(int artigoId, out string message)
        {
            if (IsCompraFechada(out message)) return false;

            this.Items.RemoveAll(i => i.ArtigoId == artigoId);
            return true;
        }

        public bool UpdateItem(int artigoId, string novaQuantidadePrevista, out string message)
        {
            int parsedQuantidadePrevista = 0;

            if (IsCompraFechada(out message)) return false;

            if (!int.TryParse(novaQuantidadePrevista, out parsedQuantidadePrevista) || parsedQuantidadePrevista <= 0)
            {
                message = "Por favor, insira uma quantidade prevista válida (número inteiro positivo).";
                return false;
            }

            ItemPrevisto item = this.Items.FirstOrDefault(i => i.ArtigoId == artigoId);
            if (item == null)
            {
                message = "Item não encontrado.";
                return false;
            }

            message = "Item atualizado com sucesso.";
            item.QuantidadePrevista = parsedQuantidadePrevista;
            item.utilizadorAlterouId = Sessao.UtilizadorAtual.Id;
            item.DataAlteracao = DateTime.Now;

            return true;
        }

        public bool Save(string name, out string message)
        {
            if (!Validate(name, out message)) return false;
            if (IsCompraFechada(out message)) return false;

            using (iShoppingContext db = new iShoppingContext())
            {
                Compra compra;

                if (this.CompraId == 0)
                {
                    compra = new Compra
                    {
                        Nome = name.Trim(),
                        DataInicio = DateTime.Now,
                        Fechada = false,
                        utilizadorId = Sessao.UtilizadorAtual.Id,
                    };

                    db.Compras.Add(compra);
                } else
                {
                    compra = db.Compras.Find(this.CompraId);
                    
                    if (compra == null)
                    {
                        message = "Compra não encontrada.";
                        return false;
                    }

                    if (name.Trim() != "")
                    {
                        compra.Nome = name.Trim();
                    }
                }

                db.SaveChanges(); // salva para gerar o ID da compra

                List<ItemPrevisto> itensDB = db.ItensPrevistos.Where(i => i.CompraId == compra.Id).ToList();

                // sincronizar dados locais com a DB
                foreach (ItemPrevisto itemDB in itensDB)
                {
                    if (!this.Items.Any(i => i.ArtigoId == itemDB.ArtigoId))
                    {
                        db.ItensPrevistos.Remove(itemDB);
                    }
                }

                foreach (ItemPrevisto item in this.Items)
                {
                    ItemPrevisto itemExists = itensDB.FirstOrDefault(i => i.ArtigoId == item.ArtigoId);
                    
                    if (itemExists == null)
                    {

                        db.ItensPrevistos.Add(new ItemPrevisto
                        {
                            CompraId = compra.Id,
                            ArtigoId = item.ArtigoId,
                            TipoArtigoId = item.TipoArtigoId,
                            DataCriacao = item.DataCriacao,
                            utilizadorCriouId = item.utilizadorCriouId,
                            QuantidadePrevista = item.QuantidadePrevista,
                            QuantidadeAdquirida = 0,
                            PrecoUnitario = 0,
                        });
                    }
                    else
                    {
                        itemExists.QuantidadePrevista = item.QuantidadePrevista;
                        itemExists.DataAlteracao = item.DataAlteracao;
                        itemExists.utilizadorAlterouId = item.utilizadorAlterouId;
                    }
                }

                db.SaveChanges();
            }

            if (this.CompraId > 0)
            {
                message = "Planeamento de compra alterado com sucesso.";
            }
            else
            {
                message = "Planeamento de compra criado com sucesso.";
            }

            return true;
        }
    }
}
