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

        public FormCriacaoAlteracao(int compraId, bool isClosed) {
            InitializeComponent();
            controller = new FormCriacaoAlteracaoController(compraId);
            this.compraId = compraId;
            this.isClosed = isClosed;
        }

        private void UpdateGrid(bool onLoad = false)
        {
            dataGridViewItens.DataSource = null;

            if (onLoad)
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    dataGridViewItens.DataSource = db.ItensPrevistos
                        .Where(i => i.CompraId == this.compraId)
                        .Select(i => new
                        {
                            i.Id,
                            i.ArtigoId,
                            Artigo = i.Artigo.Nome,
                            i.QuantidadePrevista,
                            i.DataCriacao,
                            i.DataAlteracao,
                            i.utilizadorCriouId,
                            i.utilizadorAlterouId
                        }).ToList();
                }
            } else
            {
                dataGridViewItens.DataSource = this.controller.Items.Select(i => new {
                    i.Id,
                    i.ArtigoId,
                    Artigo = i.Artigo.Nome,
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

            List<TipoArtigo> tiposArtigos = FormCriacaoAlteracaoController.GetTiposArtigos();
            comboBoxTipoArtigos.DataSource = tiposArtigos;
            comboBoxTipoArtigos.DisplayMember = "Tipo";
            comboBoxTipoArtigos.ValueMember = "Id";

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

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            int tipoId = (int)comboBoxTipoArtigos.SelectedValue;
            int artigoId = (int)comboBoxArtigos.SelectedValue;

            dataGridViewItens.DataSource = this.controller.GetArtigosPorTipo(tipoId, artigoId);
        }
    }
}
