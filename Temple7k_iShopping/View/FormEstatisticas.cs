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
        }

        private void dataGridViewOrçamentoMes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
