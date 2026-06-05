using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple7k_iShopping.Model
{
    internal class AppInitializer : DropCreateDatabaseAlways<iShoppingContext>
    {
        protected override void Seed(iShoppingContext context)
        {
            context.Utilizadores.Add(new Utilizador { Username = "admin", Password = "admin" });
            context.Utilizadores.Add(new Utilizador { Username = "user1", Password = "123" });

            context.Artigos.Add(new Artigo { Nome = "ExemploArtigo", TipoArtigoId = 1 });
            context.Artigos.Add(new Artigo { Nome = "BBB", TipoArtigoId = 2 });
            context.Artigos.Add(new Artigo { Nome = "CCC", TipoArtigoId = 3 });

            context.TipoArtigo.Add(new TipoArtigo { Tipo = "Exemplo" });
            context.TipoArtigo.Add(new TipoArtigo { Tipo = "BCB" });
            context.TipoArtigo.Add(new TipoArtigo { Tipo = "CCC" });

            base.Seed(context);
        }
    }
}
