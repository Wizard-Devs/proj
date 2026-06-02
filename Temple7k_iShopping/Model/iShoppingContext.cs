using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Temple7k_iShopping.Model
{
    internal class iShoppingContext : DbContext
    {
        public iShoppingContext() : base("iShopping") { }

        public DbSet<Compra> Compras { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<ItemCompra> ItensCompra { get; set; }
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<TipoArtigo> TipoArtigo { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<ItemPrevisto> ItensPrevistos { get; set; }
        public DbSet<ItemNaoPrevisto> ItensNaoPrevistos { get; set; }
    }
}
