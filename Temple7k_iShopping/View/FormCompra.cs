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

        /*
         * Atualiza o valor disponível e avisa quando o orçamento foi ultrapassado.
         * */
        private void UpdateOrcamento()
        {
            decimal orcamentoDisponivel = controller.GetOrcamentoDisponivel();

            labelOrcamentoAtual.Text = $"{orcamentoDisponivel:f2} €";

            if (orcamentoDisponivel < 0)
            {
                MessageBox.Show("O orçamento para esta compra foi ultrapassado, remova itens ou adicione mais fundos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateGrid()
        {
            dataGridViewCompra.DataSource = null;

            // converte os itens para um formato simples de apresentar na DataGridView.
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

            labelNomeCompra.Text = this.nameCompra;

            UpdateGrid();
            UpdateOrcamento();
        }

        private void dataGridViewCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompra.CurrentRow == null) return;

            DataGridViewRow row = dataGridViewCompra.CurrentRow;

            if (row.Cells["Quantidade"].Value == null || row.Cells["PrecoUnitario"].Value == null) return;

            // preenche os campos do formulário com os dados da linha selecionada.
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
            UpdateOrcamento();
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
            UpdateOrcamento();
        }

        private void button3Remover_Click(object sender, EventArgs e)
        {
            int artigoId = (int)comboBoxArtigos.SelectedValue;
            controller.RemoveItem(artigoId);

            UpdateGrid();
            UpdateOrcamento();
        }

        private void buttonTerminarCompra_Click(object sender, EventArgs e)
        {
            string message;

            DialogResult result = MessageBox.Show("Tens certeza que queres fechar a compra?", "Fechar Compra", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            bool success = controller.CloseCompra(out message);
            MessageBox.Show(message);

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridViewCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
