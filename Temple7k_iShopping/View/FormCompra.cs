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
    public partial class FormCompra : Form
    {
        private FormCompraController controller;
        private int idCompra;
        private string nameCompra;

        public FormCompra(int id, string name)
        {
            InitializeComponent();

            this.idCompra = id;
            this.nameCompra = name;

            controller = new FormCompraController(this.idCompra);
        }

        private void UpdateGrid(bool onLoad = false)
        {
            dataGridViewCompra.DataSource = null;
            dataGridViewCompra.DataSource = this.controller.Items.Select(i => new
            {
                i.Id,
                TipoItem = (i is ItemPrevisto) ? "Previsto" : "Não Previsto",
                i.ArtigoId,
                Artigo = i.Artigo.Nome,
                Quantidade = i.QuantidadeAdquirida,
                QuantidadePrevista = (i as ItemPrevisto)?.QuantidadePrevista ?? 0,
                i.PrecoUnitario,
                Observacao = (i as ItemNaoPrevisto)?.Observacao ?? "",
                i.DataCriacao,
                i.DataAlteracao,
                i.utilizadorCriouId,
                i.utilizadorAlterouId,
            }).ToList();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            List<Artigo> artigos = FormCriacaoAlteracaoController.GetArtigos();
            comboBoxArtigos.DataSource = artigos;
            comboBoxArtigos.DisplayMember = "Nome";
            comboBoxArtigos.ValueMember = "Id";

            UpdateGrid();
        }

        private void dataGridViewCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompra.CurrentRow == null) return;

            DataGridViewRow row = dataGridViewCompra.CurrentRow;

            if (row.Cells["Quantidade"].Value == null || row.Cells["PrecoUnitario"].Value == null) return;

            textBoxQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
            textBoxPrecoUnitario.Text = row.Cells["PrecoUnitario"].Value.ToString();
            richTextBoxObservacao.Text = row.Cells["Observacao"].Value.ToString();
            comboBoxArtigos.SelectedValue = (int)row.Cells["ArtigoId"].Value;
        }

        private void button1Adicionar_Click(object sender, EventArgs e)
        {
            string message;

            string quantidade = textBoxQuantidade.Text.Trim();
            string precoUnitario = textBoxPrecoUnitario.Text.Trim();
            string observacao = richTextBoxObservacao.Text;

            int artigoId = (int)comboBoxArtigos.SelectedValue;

            bool success = controller.AddItems(quantidade, precoUnitario, observacao, artigoId, out message);
            MessageBox.Show(message);

            UpdateGrid();
        }

        private void button2Alterar_Click(object sender, EventArgs e)
        {
            string message;

            string quantidade = textBoxQuantidade.Text.Trim();
            string precoUnitario = textBoxPrecoUnitario.Text.Trim();
            string observacao = richTextBoxObservacao.Text;

            int artigoId = (int)comboBoxArtigos.SelectedValue;

            bool success = controller.UpdateItem(quantidade, precoUnitario, observacao, artigoId, out message);
            MessageBox.Show(message);

            UpdateGrid();
        }
    }
}
