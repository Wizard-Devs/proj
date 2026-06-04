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
    public partial class Form_gestao_tipos_de_artigo : Form
    {
        public Form_gestao_tipos_de_artigo()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            dataGridView1.DataSource = FormGestaoTipoArtigosController.ObterTiposArtigos();
        }

        private void LimparCampos()
        {
            textBox1TipoArtigo.Text = "";
            textBox1Id.Text = "";
            dataGridView1.ClearSelection();
        }


        private void button1Adicionar_Click(object sender, EventArgs e)
        {
            string message;
            string addTipoArtigo = textBox1TipoArtigo.Text.Trim();

            bool addCorrect = FormGestaoTipoArtigosController.AdicionarTipoArtigo(addTipoArtigo, out message);
            MessageBox.Show(message);

            if (addCorrect)
            {
                CarregarDados();
                textBox1TipoArtigo.Clear();
            }
        }

        private void Form_gestao_tipos_de_artigo_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                TipoArtigo tipo = (TipoArtigo)dataGridView1.CurrentRow.DataBoundItem;
                textBox1TipoArtigo.Text = tipo.Tipo;
                textBox1Id.Text = tipo.Id.ToString();
            }
        }

        private void button2Alterar_Click(object sender, EventArgs e)
        {
            int id;
            string tipoArtigo = textBox1TipoArtigo.Text;

            if(!int.TryParse(textBox1Id.Text, out id))
            {
                MessageBox.Show("O ID deve ser numérico");
                return;
            }

            if (string.IsNullOrEmpty(tipoArtigo))
            {
                MessageBox.Show("O campo precisa estar preenchido");
                return;
            }

            string mensagem;
            bool ok = FormGestaoTipoArtigosController.AtualizarTipo(id, tipoArtigo, out mensagem);

            MessageBox.Show(mensagem);

            if (ok)
            {
                LimparCampos();
                CarregarDados();
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
