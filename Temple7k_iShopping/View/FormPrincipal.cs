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
using Temple7k_iShopping.View;

namespace Temple7k_iShopping
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = FormPrincipalController.GetOpenCompras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_gestao_tipos_de_artigo form = new Form_gestao_tipos_de_artigo();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGestaoOrcamentos form = new FormGestaoOrcamentos();
            form.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FormGestaoArtigos form = new FormGestaoArtigos();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPlaneamentoCompras form = new FormPlaneamentoCompras();
            form.ShowDialog();
            UpdateGrid();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Ficheiros CSV (*.csv)|*.csv";
            sfd.Title = "Guardar ficheiro CSV";
            sfd.FileName = "compras_fechadas.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FormPrincipalController.ExportarCsv(sfd.FileName);
                MessageBox.Show("Ficheiro CSV exportado com sucesso.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idCompra = 0;
            string nameCompra = "";

            Orcamento orcamento = FormCompraController.GetOrcamento();

            if (orcamento == null)
            {
                MessageBox.Show("Não foi possível obter o orçamento para o mês atual.");
                return;
            }

            if (dataGridViewPrincipal.SelectedRows.Count > 0)
            {
                idCompra = (int)dataGridViewPrincipal.SelectedRows[0].Cells["Id"]?.Value;
                nameCompra = (string)dataGridViewPrincipal.SelectedRows[0].Cells["Nome"]?.Value;

            }

            if (idCompra == 0)
            {
                MessageBox.Show("Nenhuma compra selecionada. Por favor selecione uma compra.");
                return;
            }
            
            FormCompra form = new FormCompra(idCompra, nameCompra);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormEstatisticas form = new FormEstatisticas();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormGestaoUtilizadores form = new FormGestaoUtilizadores();
            form.ShowDialog();
        }
    }
}
