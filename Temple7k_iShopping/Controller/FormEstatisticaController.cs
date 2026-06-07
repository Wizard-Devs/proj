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
    }
}
