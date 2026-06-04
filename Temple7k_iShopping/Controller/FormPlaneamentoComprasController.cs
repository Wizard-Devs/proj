using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormPlaneamentoComprasController
    {
        public static List<TipoArtigo> GetFilters()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.ToList();
            }
        }

        public static List<Artigo> GetArtigos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.ToList();
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
    }
}
