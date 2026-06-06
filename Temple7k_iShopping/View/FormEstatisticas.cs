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

namespace Temple7k_iShopping.View
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridViewOrçamentoMes.DataSource = null;
            dataGridViewOrçamentoMes.DataSource = FormGestaoOrcamentosController.GetOrcamentos();
        }

        private void tabPageListagem_Click(object sender, EventArgs e)
        {

        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
