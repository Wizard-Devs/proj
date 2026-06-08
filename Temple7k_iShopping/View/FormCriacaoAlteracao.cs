using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.DependencyResolution;
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
        private int compraId;
        private bool isClosed;
        private string nomeCompra;

        public FormCriacaoAlteracao(int compraId, bool isClosed, string nomeCompra) {
            InitializeComponent();
            controller = new FormCriacaoAlteracaoController(compraId);
            this.compraId = compraId;
            this.isClosed = isClosed;
            this.nomeCompra = nomeCompra;
        }

        private void UpdateGrid(bool onLoad = false)
        {
            dataGridViewItens.DataSource = null;

            if (onLoad)
            {
                // no carregamento inicial, carrega os itens diretamente da DB
                using (iShoppingContext db = new iShoppingContext())
                {
                    dataGridViewItens.DataSource = db.ItensPrevistos
                        .Where(i => i.CompraId == this.compraId)
                        .Select(i => new
                        {
                            i.Id,
                            i.ArtigoId,
                            Artigo = i.Artigo.Nome,
                            TipoArtigo = db.TipoArtigo.FirstOrDefault(t => t.Id == i.Artigo.TipoArtigoId).Tipo,
                            i.QuantidadePrevista,
                            i.DataCriacao,
                            i.DataAlteracao,
                            i.utilizadorCriouId,
                            i.utilizadorAlterouId
                        }).ToList();
                }
            } else
            {
                // após adicionar/alterar/remover, usa os itens já carregados em memória no controller
                dataGridViewItens.DataSource = this.controller.Items.Select(i => new {
                    i.Id,
                    i.ArtigoId,
                    Artigo = i.Artigo.Nome,
                    TipoArtigo = i.TipoArtigo.Tipo,
                    i.QuantidadePrevista,
                    i.DataCriacao,
                    i.DataAlteracao,
                    i.utilizadorCriouId,
                    i.utilizadorAlterouId
                }).ToList();
            }
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

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            string message;
            int artigoId = (int)dataGridViewItens.CurrentRow.Cells["ArtigoId"].Value;

            bool success = controller.RemoveItem(artigoId, out message);

            if (!success)
            {
                MessageBox.Show(message);
                return;
            }

            UpdateGrid();
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int artigoId = (int)dataGridViewItens.CurrentRow.Cells["ArtigoId"].Value;
            string quantidadePrevista = textBoxQuantidadePrevista.Text;
            string message;

            bool success = controller.UpdateItem(artigoId, quantidadePrevista, out message);
            MessageBox.Show(message);

            UpdateGrid();
        }

        private void FormCriacaoAlteracao_Load(object sender, EventArgs e)
        {
            List<Artigo> artigos = FormCriacaoAlteracaoController.GetArtigos();
            comboBoxArtigos.DataSource = artigos;
            comboBoxArtigos.DisplayMember = "Nome";
            comboBoxArtigos.ValueMember = "Id";

            textBoxNomeCompra.Text = this.nomeCompra;

            // mostra aviso se a compra já está fechada
            if (this.isClosed)
            {
                MessageBox.Show("A compra esta fechada, pode ser apenas visualizada.");
            }

            UpdateGrid(true);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string message;
            string name = textBoxNomeCompra.Text;

            bool success = controller.Save(name, out message);
            MessageBox.Show(message);

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridViewItens_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewItens.CurrentRow == null) return;

            DataGridViewRow row = dataGridViewItens.CurrentRow;

            if (row.Cells["QuantidadePrevista"].Value == null) return;

            // preenche os campos com os dados da linha selecionada.
            textBoxQuantidadePrevista.Text = row.Cells["QuantidadePrevista"].Value.ToString();
            comboBoxArtigos.SelectedValue = (int)row.Cells["ArtigoId"].Value;
        }
    }
}
