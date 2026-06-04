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

namespace Temple7k_iShopping
{
    public partial class FormCriacaoAlteracao : Form
    {
        private FormCriacaoAlteracaoController controller;

        public FormCriacaoAlteracao()
        {
            InitializeComponent();
            controller = new FormCriacaoAlteracaoController();
        }

        private void UpdateGrid()
        {
            dataGridViewItens.DataSource = null;
            dataGridViewItens.DataSource = controller.Items;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string quantidadePrevista = textBoxQuantidadePrevista.Text;
            string message;

            int artigoId = (int)comboBoxArtigos.SelectedValue;

            bool success = controller.AddItems(quantidadePrevista, artigoId, out message);
            MessageBox.Show(message);

            UpdateGrid();
        }

        private void FormCriacaoAlteracao_Load(object sender, EventArgs e)
        {
            List<Artigo> artigos = FormCriacaoAlteracaoController.GetArtigos();
            comboBoxArtigos.DataSource = artigos;
            comboBoxArtigos.DisplayMember = "Nome";
            comboBoxArtigos.ValueMember = "Id";

            List<TipoArtigo> tiposArtigos = FormCriacaoAlteracaoController.GetTiposArtigos();
            comboBoxTipoArtigos.DataSource = tiposArtigos;
            comboBoxTipoArtigos.DisplayMember = "Tipo";
            comboBoxTipoArtigos.ValueMember = "Id";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
