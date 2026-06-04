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
    public partial class FormGestaoOrcamentos : Form
    {
        public FormGestaoOrcamentos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string message;
            string value = textBoxValorOrcamento.Text.Trim();

            if (!FormGestaoOrcamentosController.Validate(value, out message))
            {
                MessageBox.Show(message);
                return;
            }
        }
    }
}
