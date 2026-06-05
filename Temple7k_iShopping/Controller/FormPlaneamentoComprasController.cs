using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormPlaneamentoComprasController
    {
        public static List<Compra> Filter(string filter)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                if (filter == "Abertas")
                {
                    return db.Compras.Where(c => !c.Fechada).ToList();
                }
                else if (filter == "Fechadas")
                {
                    return db.Compras.Where(c => c.Fechada).ToList();
                }

                return db.Compras.ToList();
            }
        }

        public static List<Compra> GetCompras()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Compras.ToList();
            }
        }

        public static List<Artigo> GetArtigosByTipo(string tipo)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                if (string.IsNullOrWhiteSpace(tipo))
                    return new List<Artigo>();

                TipoArtigo tipoArtigo = db.TipoArtigo.FirstOrDefault(t => t.Tipo == tipo);
                if (tipoArtigo == null)
                    return new List<Artigo>();

                return db.Artigos.Where(a => a.TipoArtigoId == tipoArtigo.Id).ToList();
            }
        }

        public static void CloseCompra(out string message, DataGridView grid)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    bool isClosed = (bool)row.Cells["Fechada"].Value;

                    if (!isClosed) continue;

                    int id = (int)row.Cells["Id"].Value;
                    Compra compra = db.Compras.Find(id);

                    if (compra == null) continue;

                    compra.Fechada = true;
                    compra.DataFechada = DateTime.Now;
                    compra.utilizadorFechouId = Sessao.UtilizadorAtual.Id;
                }

                db.SaveChanges();
            }

            message = "Compra/s fechada/s com sucesso.";
        }
    }
}
