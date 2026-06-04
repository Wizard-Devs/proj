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
    public partial class FormGestaoOrcamentos : Form
    {
        public FormGestaoOrcamentos()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGridViewOrcamentos.DataSource = FormGestaoOrcamentosController.GetOrcamentos();
        }

        private int GetSelectedOrcamentoId()
        {
            if (dataGridViewOrcamentos.SelectedRows.Count == 0) return -1;
            Orcamento orcamento = dataGridViewOrcamentos.SelectedRows[0].DataBoundItem as Orcamento;

            return orcamento == null ? -1 : orcamento.Id;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string message;
            string value = textBoxValorOrcamento.Text;

            bool success = FormGestaoOrcamentosController.Add(value, out message);
            MessageBox.Show(message);

            if (success)
            {
                LoadData();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string message;
            string value = textBoxValorOrcamento.Text;
            int id = GetSelectedOrcamentoId();

            if (id == -1) { 
                MessageBox.Show("Selecione um orçamento para alterar.");
                return;
            }

            bool success = FormGestaoOrcamentosController.Edit(value, id, out message);
            MessageBox.Show(message);

            if (success)
            {
                LoadData();
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            string message;
            int id = GetSelectedOrcamentoId();

            if (id == -1)
            {
                MessageBox.Show("Selecione um orçamento para remover.");
                return;
            }

            bool success = FormGestaoOrcamentosController.Remove(id, out message);
            MessageBox.Show(message);

            if (success)
            {
                LoadData();
            }
        }

        private void FormGestaoOrcamentos_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
