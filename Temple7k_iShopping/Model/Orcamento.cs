using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple7k_iShopping.Model
{
    internal class Orcamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorInicial { get; set; }
        public int Mes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int utilizadorCriouId { get; set; }
        public int? utilizadorAlterouId { get; set; }
    }
}
