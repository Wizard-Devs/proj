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
            dataGridViewPlaneamentoCompras.DataSource = FormPlaneamentoComprasController.GetArtigos();
        }

        private void button3CriarAlterar_Click(object sender, EventArgs e)
        {
            FormCriacaoAlteracao form = new FormCriacaoAlteracao();
            form.ShowDialog();
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
