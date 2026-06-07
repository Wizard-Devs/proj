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

                if(compra.Count == 0)
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

        public static List<double> ItemsPercentage()
        {
            int itemsPrevistos = 0;
            int itemsNaoPrevistos = 0;
            int itemsTotal = 0;

            using (iShoppingContext db = new iShoppingContext())
            {
                List<Compra> compras = PegarItemCompra();

                foreach (Compra compra in compras)
                {
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
                }
            }

            double percentageItemsPrevistos = itemsTotal > 0 ? (double)itemsPrevistos / (double)itemsTotal * 100 : 0;
            double percentageItemsNaoPrevistos = itemsTotal > 0 ? (double)itemsNaoPrevistos / (double)itemsTotal * 100 : 0;

            return new List<double> { percentageItemsPrevistos, percentageItemsNaoPrevistos };
        }


    }
}
