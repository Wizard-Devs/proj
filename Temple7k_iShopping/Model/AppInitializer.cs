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
            context.Utilizadores.Add(new Utilizador { Username = "user1", Password = "123" });
            context.SaveChanges();

            context.TipoArtigo.Add(new TipoArtigo { Tipo = "Exemplo" });
            context.TipoArtigo.Add(new TipoArtigo { Tipo = "BCB" });
            context.TipoArtigo.Add(new TipoArtigo { Tipo = "CCC" });
            context.SaveChanges();

            context.Artigos.Add(new Artigo { Nome = "ExemploArtigo", TipoArtigoId = 1 });
            context.Artigos.Add(new Artigo { Nome = "BBB", TipoArtigoId = 2 });
            context.Artigos.Add(new Artigo { Nome = "CCC", TipoArtigoId = 3 });
            context.SaveChanges();

            context.Orcamentos.Add(new Orcamento { ValorInicial = 500, Valor = 500, Mes = 1, DataCriacao = DateTime.Now, utilizadorCriouId = 1 });
            context.Orcamentos.Add(new Orcamento { ValorInicial = 400, Valor = 180, Mes = 2, DataCriacao = DateTime.Now, utilizadorCriouId = 1 });
            context.Orcamentos.Add(new Orcamento { ValorInicial = 300, Valor = -20, Mes = 3, DataCriacao = DateTime.Now, utilizadorCriouId = 1 });
            context.Orcamentos.Add(new Orcamento { ValorInicial = 200, Valor = -20, Mes = 6, DataCriacao = DateTime.Now, utilizadorCriouId = 1 });
            context.SaveChanges();

            context.Compras.Add(new Compra { Nome = "Compra Atual", DataInicio = DateTime.Now, Fechada = false, utilizadorId = 1 });

            context.Compras.Add(new Compra { Nome = "Compra Abril 1ª Semana", DataInicio = new DateTime(2026, 4, 3), Fechada = true, DataFechada = new DateTime(2026, 4, 3), utilizadorId = 1, utilizadorFechouId = 1 });
            context.Compras.Add(new Compra { Nome = "Compra Março 1ª Semana", DataInicio = new DateTime(2026, 3, 5), Fechada = true, DataFechada = new DateTime(2026, 3, 5), utilizadorId = 1, utilizadorFechouId = 1 });
            context.Compras.Add(new Compra { Nome = "Compra Maio 1ª Semana", DataInicio = new DateTime(2026, 5, 2), Fechada = true, DataFechada = new DateTime(2026, 5, 2), utilizadorId = 1, utilizadorFechouId = 1 });
            context.SaveChanges();

            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 1, ArtigoId = 1, QuantidadePrevista = 3, QuantidadeAdquirida = 0, PrecoUnitario = 0, DataCriacao = DateTime.Now, utilizadorCriouId = 1 });

            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 2, ArtigoId = 1, QuantidadePrevista = 2, QuantidadeAdquirida = 2, PrecoUnitario = 1.50m, DataCriacao = new DateTime(2026, 4, 3), utilizadorCriouId = 1 });
            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 2, ArtigoId = 2, QuantidadePrevista = 1, QuantidadeAdquirida = 1, PrecoUnitario = 4.99m, DataCriacao = new DateTime(2026, 4, 3), utilizadorCriouId = 1 });

            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 3, ArtigoId = 1, QuantidadePrevista = 3, QuantidadeAdquirida = 3, PrecoUnitario = 1.50m, DataCriacao = new DateTime(2026, 3, 5), utilizadorCriouId = 1 });
            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 3, ArtigoId = 3, QuantidadePrevista = 2, QuantidadeAdquirida = 2, PrecoUnitario = 2.30m, DataCriacao = new DateTime(2026, 3, 5), utilizadorCriouId = 1 });

            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 4, ArtigoId = 1, QuantidadePrevista = 2, QuantidadeAdquirida = 2, PrecoUnitario = 1.50m, DataCriacao = new DateTime(2026, 5, 2), utilizadorCriouId = 1 });
            context.ItensPrevistos.Add(new ItemPrevisto { CompraId = 4, ArtigoId = 2, QuantidadePrevista = 1, QuantidadeAdquirida = 1, PrecoUnitario = 4.99m, DataCriacao = new DateTime(2026, 5, 2), utilizadorCriouId = 1 });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
