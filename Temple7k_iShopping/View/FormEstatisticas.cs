using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Controller;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping.View
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridViewOrcamentoMes.DataSource = null;
            dataGridViewOrcamentoMes.DataSource = FormEstatisticaController.GetOrcamentos();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FormEstatisticaController.PegarItemCompra();
        }

        private void tabPageListagem_Click(object sender, EventArgs e)
        {

        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            CarregarOrcamentos();
        }

        private void CarregarOrcamentos()
        {
            List<Orcamento> orcamentos = FormEstatisticaController.GetOrcamentos();

            dataGridViewOrcamentoMes.DataSource = orcamentos.Select(o => new
            {
                Mes = new DateTime(DateTime.Now.Year, o.Mes, 1).ToString("MMM/yyyy"),
                Orcamento = o.ValorInicial,
                Gasto = o.ValorInicial - o.Valor,
                Diferenca = o.Valor
            }).ToList();

            var compras = FormEstatisticaController.ItemsPercentage();
            dataGridView1.DataSource = compras;

            List<Orcamento> orcamento = FormEstatisticaController.GetOrcamentos();

            decimal orcamentoTotalFunds = orcamento.Sum(o => o.ValorInicial);
            int orcamentoTotalMes = orcamento.Count();

            labelOrcamentoSugerido.Text = (orcamentoTotalFunds / orcamentoTotalMes).ToString("F2") + " €";

        }

        private void dataGridViewOrçamentoMes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1GerarSugestao_Click(object sender, EventArgs e)
        {
            string message;
            List<ItemPrevisto> sugestao;
            sugestao = FormEstatisticaController.SugerirCompras(out message);

            if(message != "")
            {
                MessageBox.Show(message);
                return;
            }

            sugestao = FormEstatisticaController.AgruparItens(sugestao);

            dataGridView2.DataSource = null;

            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("Artigo", "Artigo");
            dataGridView2.Columns.Add("Quantidade", "Quantidade Prevista");
            dataGridView2.Rows.Clear();

            foreach (ItemPrevisto item in sugestao)
            {
                dataGridView2.Rows.Add(FormEstatisticaController.PegarNomeArtigo(item.ArtigoId), item.QuantidadePrevista);
            }
        }
    }
}
