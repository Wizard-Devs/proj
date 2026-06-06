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
    public partial class FormPlaneamentoCompras : Form
    {
        public FormPlaneamentoCompras()
        {
            InitializeComponent();
        }

        private void LoadData(List<Compra> filter = null)
        {
            dataGridViewPlaneamentoCompras.DataSource = filter != null ? filter : FormPlaneamentoComprasController.GetCompras();
        }

        private void button3CriarAlterar_Click(object sender, EventArgs e)
        {
            int idCompra = 0;
            bool isClosed = false;
            string nomeCompra = "";

            if (dataGridViewPlaneamentoCompras.SelectedRows.Count > 0) {
                idCompra = (int)dataGridViewPlaneamentoCompras.SelectedRows[0].Cells["Id"]?.Value;
                nomeCompra = (string)dataGridViewPlaneamentoCompras.SelectedRows[0].Cells["Nome"]?.Value;
                isClosed = (bool)dataGridViewPlaneamentoCompras.SelectedRows[0].Cells["Fechada"]?.Value;

            }

            FormCriacaoAlteracao form = new FormCriacaoAlteracao(idCompra, isClosed, nomeCompra);
            var result = form.ShowDialog();

            if (result == DialogResult.OK) {
                LoadData();
            }
        }

        private void FormPlaneamentoCompras_Load(object sender, EventArgs e)
        {
            List<string> filters = new List<string> { "Todas", "Abertas", "Fechadas" };
            comboBoxFiltrosExistentes.DataSource = filters;

            LoadData();
        }

        private void button2Filtrar_Click(object sender, EventArgs e)
        {
            string filter = (string)comboBoxFiltrosExistentes.SelectedValue;
            List<Compra> filteredList = FormPlaneamentoComprasController.Filter(filter);

            LoadData(filteredList);
        }

        private void buttonFecharCompras_Click(object sender, EventArgs e)
        {
            string message;

            FormPlaneamentoComprasController.CloseCompra(out message, dataGridViewPlaneamentoCompras);
            MessageBox.Show(message);

            LoadData();
        }
    }
}
