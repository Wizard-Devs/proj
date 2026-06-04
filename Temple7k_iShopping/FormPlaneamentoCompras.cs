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

        private void LoadData()
        {
            dataGridViewPlaneamentoCompras.DataSource = FormPlaneamentoComprasController.GetCompras();
        }

        private void button3CriarAlterar_Click(object sender, EventArgs e)
        {
            int idCompra = 0;

            if (dataGridViewPlaneamentoCompras.SelectedRows.Count > 0) {
                idCompra = (int)dataGridViewPlaneamentoCompras.SelectedRows[0].Cells["Id"]?.Value;
            }

            FormCriacaoAlteracao form = new FormCriacaoAlteracao(idCompra);
            var result = form.ShowDialog();

            if (result == DialogResult.OK) {
                LoadData();
            }
        }

        private void FormPlaneamentoCompras_Load(object sender, EventArgs e)
        {
            List<TipoArtigo> filters = FormPlaneamentoComprasController.GetFilters();
            comboBoxFiltrosExistentes.Items.AddRange(filters.Select(filter => filter.Tipo).ToArray());
        }

        private void button2Filtrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
