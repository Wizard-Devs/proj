using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple7k_iShopping.Model
{
    internal class Compra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFechada { get; set; }
        public bool Fechada { get; set; }
        public int utilizadorId { get; set; }
        public int? utilizadorFechouId { get; set; }
    }
}
