using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple7k_iShopping.Model
{
    internal class AppInitializer : DropCreateDatabaseIfModelChanges<iShoppingContext>
    {
        protected override void Seed(iShoppingContext context)
        {
            context.Utilizadores.Add(new Utilizador { Username = "admin", Password = "admin" });
            base.Seed(context);
        }
    }
}
