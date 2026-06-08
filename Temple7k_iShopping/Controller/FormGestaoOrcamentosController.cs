using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.Controller
{
    internal class FormGestaoOrcamentosController
    {
        public static List<Orcamento> GetOrcamentos()
        //Essa função tem um papel de pegar todos os dados presentes na db Orçamento.
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Orcamentos.ToList();
            }
        }

        private static bool Validate(string value, out string message, out decimal parsedValue)
        // Valida se o valor informado não está vazio e pode ser convertido para decimal, retornando uma mensagem de erro.
        {
            if (value.Trim() == "")
            {
                message = "Valor do orçamento não pode ser vazio.";
                parsedValue = 0;
                return false;
            }

            if (!decimal.TryParse(value, out parsedValue))
            {
                message = "Valor do orçamento deve ser um número decimal.";
                return false;
            }

            message = "";
            return true;
        }

        public static bool Add(string value, out string message)
        // Valida e adiciona um novo orçamento ao mes atual, impedindo a criação de mais de um orçamento por mes.
        {
            decimal parsedValue;

            if (!Validate(value, out message, out parsedValue))
            {
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            { 
                bool exists = db.Orcamentos.Any(o => o.DataCriacao.Month == DateTime.Now.Month);

                if (exists) { 
                    message = "Já existe um orçamento para este mês.";
                    return false;
                }

                Orcamento orcamento = new Orcamento
                {
                    Valor = parsedValue,
                    ValorInicial = parsedValue,
                    Mes = DateTime.Now.Month,
                    DataCriacao = DateTime.Now,
                    utilizadorCriouId = Sessao.UtilizadorAtual.Id
                };

                db.Orcamentos.Add(orcamento);
                db.SaveChanges();
            }

            message = "Orçamento adicionado com sucesso.";
            return true;
        }

        public static bool Edit(string value, int id, out string message)
        // Valida e atualiza os dados de um orçamento existente, registando a data e o utilizador que realizou a alteração.
        {
            decimal parsedValue;

            if (!Validate(value, out message, out parsedValue))
            {
                return false;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Orcamento orcamento = db.Orcamentos.Find(id);

                if (orcamento == null) { 
                    message = "Orçamento não encontrado.";
                    return false;
                }

                orcamento.Valor = parsedValue;
                orcamento.ValorInicial = parsedValue;
                orcamento.DataAlteracao = DateTime.Now;
                orcamento.utilizadorAlterouId = Sessao.UtilizadorAtual.Id;

                db.SaveChanges();
            }

            message = "Orçamento alterado com sucesso.";
            return true;
        }

        public static bool Remove(int id, out string message)
        // Remove um orçamento existente da base de dados com base no ID fornecido.
        {

            using (iShoppingContext db = new iShoppingContext())
            {
                Orcamento orcamento = db.Orcamentos.Find(id);

                if (orcamento == null)
                {
                    message = "Orçamento não encontrado.";
                    return false;
                }

                db.Orcamentos.Remove(orcamento);
                db.SaveChanges();
            }

            message = "Orçamento removido com sucesso.";
            return true;
        }
    }
}
