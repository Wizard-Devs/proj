using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoOrcamentosController
    {
        static public bool Validate(string value, out string message)
        {
            decimal parsedValue;

            if (!decimal.TryParse(value, out parsedValue))
            {
                message = "Valor do orçamento deve ser um número decimal.";
                return false;
            }

            message = "";
            return true;
        }
    }
}
