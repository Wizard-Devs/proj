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

namespace Temple7k_iShopping
{
    public partial class Form_gestao_tipos_de_artigo : Form
    {
        public Form_gestao_tipos_de_artigo()
        {
            InitializeComponent();
        }

        private void button1Adicionar_Click(object sender, EventArgs e)
        {
            string message;
            string addTipoArtigo = textBox1TipoArtigo.Text.Trim();

            bool addCorrect = FormGestaoTipoArtigosController.AdicionarTipoArtigo(addTipoArtigo, out message);
        }
    }
}
