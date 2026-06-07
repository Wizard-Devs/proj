using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormEstatisticaController
    {
        internal class CompraWithPercentage {
            public string Nome { get; set; }
            public DateTime DataInicio { get; set; }
            public DateTime? DataFechada { get; set; }
            public bool Fechada { get; set; }
            public int utilizadorId { get; set; }
            public int? utilizadorFechouId { get; set; }
            public string PercentagemPrevistos { get; set; }
            public string PercentagemNaoPrevistos { get; set; }
        }

        public static List<Orcamento> GetOrcamentos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamentos.ToList();
            }
        }

        public static List<Compra> PegarItemCompra()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.Where(c => c.Fechada).ToList();
            }
        }

        public static List<ItemPrevisto> SugerirCompras(out string message)
        {
            int semanaAtual = PegarSemanaAtual();

            using (iShoppingContext db = new iShoppingContext())
            {
                List<Compra> compra = db.Compras
                    .Where(c => c.Fechada)
                    .ToList()
                    .Where(c => PegarSemana(c.DataInicio.Day) == semanaAtual && !(c.DataInicio.Month == DateTime.Now.Month && c.DataInicio.Year == DateTime.Now.Year))
                    .ToList();

                if (compra.Count == 0)
                {
                    message = "Ddos insuficientes para sugerir na lista";
                    return new List<ItemPrevisto>();
                }

                List<int> compraIds = compra.Select(c => c.Id).ToList();

                message = "";
                return db.ItensPrevistos.Where(i => compraIds.Contains(i.CompraId)).ToList();
            }
        }

        public static int PegarSemanaAtual()
        {
            return PegarSemana(DateTime.Now.Day);
        }

        public static int PegarSemana(int dia)
        {
            if(dia <= 7)
            {
                return 1;
            }
            else if(dia <= 14)
            {
                return 2;
            }
            else if(dia <= 21)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public static string PegarNomeArtigo(int artigoID)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.Find(artigoID)?.Nome;
            }
        }

        public static List<CompraWithPercentage> ItemsPercentage()
        {
            var result = new List<CompraWithPercentage>();

            
            using (iShoppingContext db = new iShoppingContext())
            {
                List<Compra> compras = PegarItemCompra();

                foreach (Compra compra in compras)
                {
                    int itemsPrevistos = 0;
                    int itemsNaoPrevistos = 0;
                    int itemsTotal = 0;

                    List<ItemCompra> items = db.ItensCompra.Where(i => i.CompraId == compra.Id).ToList();

                    itemsTotal = items.Count();

                    foreach (ItemCompra item in items)
                    {
                        if (item is ItemPrevisto previsto)
                        {
                            itemsPrevistos++;
                        }
                        else
                        {
                            itemsNaoPrevistos++;
                        }
                    }

                    double percentageItemsPrevistos = itemsTotal > 0 ? (double)itemsPrevistos / (double)itemsTotal * 100 : 0;
                    double percentageItemsNaoPrevistos = itemsTotal > 0 ? (double)itemsNaoPrevistos / (double)itemsTotal * 100 : 0;

                    result.Add(new CompraWithPercentage
                    {
                        Nome = compra.Nome,
                        DataInicio = compra.DataInicio,
                        DataFechada = compra.DataFechada,
                        Fechada = compra.Fechada,
                        PercentagemPrevistos = $"{percentageItemsPrevistos:f2}%",
                        PercentagemNaoPrevistos = $"{percentageItemsNaoPrevistos:f2}%",
                        utilizadorId = compra.utilizadorId,
                        utilizadorFechouId = compra.utilizadorFechouId
                    });
                }
            }

            return result;
        }

        public static List<ItemPrevisto> AgruparItens(List<ItemPrevisto> itens)
        {
            return itens
                .GroupBy(i => i.ArtigoId)
                .Select(g => new ItemPrevisto
                {
                    ArtigoId = g.Key,
                    QuantidadePrevista = (int)g.Average(i => i.QuantidadePrevista)
                })
                .ToList();
        }
    }
}
