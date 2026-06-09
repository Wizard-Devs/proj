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
            //UTILIZADORES
            /* ------------------------------------------------------------*/
            context.Utilizadores.Add(new Utilizador
            {
                Username = "admin",
                Password = "admin"
            });

            context.Utilizadores.Add(new Utilizador
            {
                Username = "user1",
                Password = "123"
            });

            context.SaveChanges();

            //TIPOARTIGO
            /* ------------------------------------------------------------*/

            context.TipoArtigo.Add(new TipoArtigo
            {
                Tipo = "Exemplo"
            });

            context.TipoArtigo.Add(new TipoArtigo
            {
                Tipo = "BCB"
            });

            context.TipoArtigo.Add(new TipoArtigo
            {
                Tipo = "CCC"
            });

            context.SaveChanges();

            //ARTIGOS
            /* ------------------------------------------------------------*/

            context.Artigos.Add(new Artigo
            {
                Nome = "ExemploArtigo",
                TipoArtigoId = 1
            });

            context.Artigos.Add(new Artigo
            {
                Nome = "BBB",
                TipoArtigoId = 2
            });

            context.Artigos.Add(new Artigo
            {
                Nome = "CCC",
                TipoArtigoId = 3
            });
            context.SaveChanges();

            //ORCAMENTOS
            /* ------------------------------------------------------------*/

            context.Orcamentos.Add(new Orcamento
            {
                ValorInicial = 500,
                Valor = 500,
                Mes = 1,
                DataCriacao = DateTime.Now,
                utilizadorCriouId = 1
            });

            context.Orcamentos.Add(new Orcamento
            {
                ValorInicial = 400,
                Valor = 180,
                Mes = 2,
                DataCriacao = DateTime.Now,
                utilizadorCriouId = 1
            });

            context.Orcamentos.Add(new Orcamento
            {
                ValorInicial = 300,
                Valor = -20,
                Mes = 3,
                DataCriacao = DateTime.Now,
                utilizadorCriouId = 1
            });

            context.Orcamentos.Add(new Orcamento
            {
                ValorInicial = 200,
                Valor = -20,
                Mes = 6,
                DataCriacao = DateTime.Now,
                utilizadorCriouId = 1
            });

            context.SaveChanges();

            //COMPRAS
            /* ------------------------------------------------------------*/

            context.Compras.Add(new Compra
            {
                Nome = "Compra Atual",
                DataInicio = DateTime.Now,
                Fechada = false,
                utilizadorId = 1
            });

            // semana 1
            context.Compras.Add(new Compra
            {
                Nome = "Compra Abril 1ª Semana",
                DataInicio = new DateTime(2026, 4, 3),
                Fechada = true,
                DataFechada = new DateTime(2026, 4, 3),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Março 1ª Semana",
                DataInicio = new DateTime(2026, 3, 3),
                Fechada = true,
                DataFechada = new DateTime(2026, 3, 3),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Maio 1ª Semana",
                DataInicio = new DateTime(2026, 5, 3),
                Fechada = true,
                DataFechada = new DateTime(2026, 5, 3),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            // semana 2
            context.Compras.Add(new Compra
            {
                Nome = "Compra Abril 2ª Semana",
                DataInicio = new DateTime(2026, 4, 9),
                Fechada = true,
                DataFechada = new DateTime(2026, 4, 9),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Março 2ª Semana",
                DataInicio = new DateTime(2026, 3, 9),
                Fechada = true,
                DataFechada = new DateTime(2026, 3, 9),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Maio 2ª Semana",
                DataInicio = new DateTime(2026, 5, 9),
                Fechada = true,
                DataFechada = new DateTime(2026, 5, 9),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            // semana 3
            context.Compras.Add(new Compra
            {
                Nome = "Compra Abril 3ª Semana",
                DataInicio = new DateTime(2026, 4, 17),
                Fechada = true,
                DataFechada = new DateTime(2026, 4, 17),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Março 3ª Semana",
                DataInicio = new DateTime(2026, 3, 17),
                Fechada = true,
                DataFechada = new DateTime(2026, 3, 17),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Maio 3ª Semana",
                DataInicio = new DateTime(2026, 5, 17),
                Fechada = true,
                DataFechada = new DateTime(2026, 5, 17),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            // semana 4
            context.Compras.Add(new Compra
            {
                Nome = "Compra Abril 4ª Semana",
                DataInicio = new DateTime(2026, 4, 24),
                Fechada = true,
                DataFechada = new DateTime(2026, 4, 24),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Março 4ª Semana",
                DataInicio = new DateTime(2026, 3, 24),
                Fechada = true,
                DataFechada = new DateTime(2026, 3, 24),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });

            context.Compras.Add(new Compra
            {
                Nome = "Compra Maio 4ª Semana",
                DataInicio = new DateTime(2026, 5, 24),
                Fechada = true,
                DataFechada = new DateTime(2026, 5, 24),
                utilizadorId = 1,
                utilizadorFechouId = 1
            });
            context.SaveChanges();

            //ITENSPREVISTOS
            /* ------------------------------------------------------------*/

            // semana 1
            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 2,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 4, 3),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 2,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 4, 3),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 3,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 3,
                QuantidadeAdquirida = 3,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 3, 3),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 3,
                ArtigoId = 3,
                TipoArtigoId = 3,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 2.30m,
                DataCriacao = new DateTime(2026, 3, 3),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 4,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 5, 3),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 4,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 5, 3),
                utilizadorCriouId = 1
            });

            // semana 2
            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 5,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 4, 9),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 5,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 4, 9),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 6,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 3,
                QuantidadeAdquirida = 3,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 3, 9),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 6,
                ArtigoId = 3,
                TipoArtigoId = 3,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 2.30m,
                DataCriacao = new DateTime(2026, 3, 9),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 7,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 5, 9),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 7,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 5, 9),
                utilizadorCriouId = 1
            });

            // semana 3
            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 8,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 4, 17),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 8,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 4, 17),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 9,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 3,
                QuantidadeAdquirida = 3,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 3, 17),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 9,
                ArtigoId = 3,
                TipoArtigoId = 3,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 2.30m,
                DataCriacao = new DateTime(2026, 3, 17),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 10,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 5, 17),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 10,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 5, 17),
                utilizadorCriouId = 1
            });

            // semana 4
            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 11,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 4, 24),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 11,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 4, 24),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 12,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 3,
                QuantidadeAdquirida = 3,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 3, 24),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 12,
                ArtigoId = 3,
                TipoArtigoId = 3,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 2.30m,
                DataCriacao = new DateTime(2026, 3, 24),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 13,
                ArtigoId = 1,
                TipoArtigoId = 1,
                QuantidadePrevista = 2,
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.50m,
                DataCriacao = new DateTime(2026, 5, 24),
                utilizadorCriouId = 1
            });

            context.ItensPrevistos.Add(new ItemPrevisto
            {
                CompraId = 13,
                ArtigoId = 2,
                TipoArtigoId = 2,
                QuantidadePrevista = 1,
                QuantidadeAdquirida = 1,
                PrecoUnitario = 4.99m,
                DataCriacao = new DateTime(2026, 5, 24),
                utilizadorCriouId = 1
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}