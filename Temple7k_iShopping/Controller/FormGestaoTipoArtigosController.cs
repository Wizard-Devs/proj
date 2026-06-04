using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoTipoArtigosController
    {


        static public bool AdicionarTipoArtigo(string tipoArtigo, out string message)
        {
            message = "";

            if(tipoArtigo == "")
            {
                message = "Preencha todos os campos.";
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                bool repetido = db.TipoArtigo.Any(T =>
                    T.Tipo == tipoArtigo
                );

                if(repetido)
                {
                    message = "Esse tipo já existe na base de dados";
                    return false;
                }

                TipoArtigo tipo = new TipoArtigo
                {
                    Tipo = tipoArtigo,
                };

                db.TipoArtigo.Add( tipo );
                db.SaveChanges();

                message = "Tipo de Artigo guardado com sucesso";
                return true;
            }
        }
    }
}
