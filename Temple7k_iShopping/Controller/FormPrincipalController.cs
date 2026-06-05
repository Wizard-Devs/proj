using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;
using System.Data.Entity;

namespace Temple7k_iShopping.Controller
{
    internal class FormPrincipalController
    {
        public static List<Compra> GetOpenCompras()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.Where(c => c.Fechada == false).ToList();
            }
        }
    }
}
