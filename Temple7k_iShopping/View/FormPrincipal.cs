using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.View;
using Temple7k_iShopping.Controller;

namespace Temple7k_iShopping
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_gestao_tipos_de_artigo form = new Form_gestao_tipos_de_artigo();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGestaoOrcamentos form = new FormGestaoOrcamentos();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPlaneamentoCompras form = new FormPlaneamentoCompras();
            form.ShowDialog();
        }
    }
}
