using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple7k_iShopping.Model
{
    internal class ItemCompra
    {
        public int Id { get; set; }
        public int ArtigoId { get; set; }
        public int CompraId { get; set; }
        public int QuantidadeAdquirida { get; set; }
        public decimal PrecoUnitario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int utilizadorCriouId { get; set; }
        public int? utilizadorAlterouId { get; set; }

        public virtual Artigo Artigo { get; set; }
        public virtual Compra Compra { get; set; }
    }
}
