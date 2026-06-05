using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormPrincipalController
    {
        public static List<Compra> GetOpenCompras()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.Where(c => !c.Fechada).ToList();
            }
        }

        public static void ExportarCsv(string caminho)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                List<ItemCompra> items = db.ItensCompra
                    .Include("Compra")
                    .Include("Artigo")
                    .Where(i => i.Compra.Fechada)
                    .OrderBy(i => i.CompraId)
                    .ToList();

                using (StreamWriter sw = new StreamWriter(caminho, false))
                {
                    sw.WriteLine("Id;NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

                    foreach (ItemCompra item in items)
                    {
                        string artigoPrevisto = "Não";
                        string artigoNaoPrevisto = "Não";
                        int quantidadePrevista = 0;

                        if (item is ItemPrevisto itemPrevisto)
                        {
                            artigoPrevisto = "Sim";
                            quantidadePrevista = itemPrevisto.QuantidadePrevista;
                        }

                        if (item is ItemNaoPrevisto itemNaoPrevisto)
                        {
                            artigoNaoPrevisto = "Sim";
                        }

                        sw.WriteLine(
                            item.CompraId + ";" +
                            EscaparCsv(item.Compra.Nome) + ";" +
                            item.Compra.DataInicio + ";" +
                            item.Compra.DataFechada + ";" +
                            EscaparCsv(item.Artigo.Nome) + ";" +
                            artigoPrevisto + ";" +
                            artigoNaoPrevisto + ";" +
                            quantidadePrevista + ";" +
                            item.QuantidadeAdquirida,
                            item.PrecoUnitario
                        );
                    }
                }
            }
        }

        private static string EscaparCsv(string valor)
        {
            if (valor == null)
            {
                return "";
            }

            if (valor.Contains(";") || valor.Contains("\""))
            {
                return "\"" + valor.Replace("\"", "\"\"") + "\"";
            }

            return valor;
        }
    }
}
