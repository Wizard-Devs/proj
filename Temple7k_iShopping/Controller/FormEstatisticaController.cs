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
