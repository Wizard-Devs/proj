using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temple7k_iShopping.Controller;
using Temple7k_iShopping.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Temple7k_iShopping
{
    public partial class FormGestaoArtigos : Form
    {
        public FormGestaoArtigos()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                Artigo Art = (Artigo)dataGridView1.CurrentRow.DataBoundItem;
                textBox1Id.Text = Art.Id.ToString();
                textBox1Artigo.Text = Art.Nome.ToString();
                comboBox2TipoArt.SelectedValue = Art.TipoArtigoId;
            }
        }

        private void CarregarDados()
        {
            dataGridView1.DataSource = FormGestaoArtigosController.ObterArtigos();

        }

        private void CarregarComboBox()
        {
            comboBox1Filtrar.Items.Clear();
            comboBox1Filtrar.Items.Add("Todos");

            foreach (TipoArtigo tipo in FormGestaoTipoArtigosController.ObterTiposArtigos())
            {
                comboBox1Filtrar.Items.Add(tipo.Tipo);
            }

            comboBox1Filtrar.SelectedIndex = 0;

            comboBox2TipoArt.DataSource = FormGestaoTipoArtigosController.ObterTiposArtigos();
            comboBox2TipoArt.DisplayMember = "Tipo";  
            comboBox2TipoArt.ValueMember = "Id";  
        }

        private void FormGestaoArtigos_Load(object sender, EventArgs e)
        {
            CarregarDados();
            CarregarComboBox();
        }

        private void button1Adicionar_Click(object sender, EventArgs e)
        {
            string mensagem;
            string nome = textBox1Artigo.Text.Trim();
            int tipoId = (int)comboBox2TipoArt.SelectedValue;

            bool addCorrect = FormGestaoArtigosController.AdicionarArtigo(nome, tipoId, out mensagem);
            MessageBox.Show(mensagem);

            if (addCorrect)
            {
                CarregarDados();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2Alterar_Click(object sender, EventArgs e)
        {
            string mensagem;
            int id = int.Parse(textBox1Id.Text);
            string nome = textBox1Artigo.Text.Trim();
            int tipoId = (int)comboBox2TipoArt.SelectedValue;

            bool sucesso = FormGestaoArtigosController.AtualizarArtigo(id, nome, tipoId, out mensagem);
            MessageBox.Show(mensagem);

            if (sucesso)
            {
                CarregarDados();
            }
        }

        private void button3Remover_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(textBox1Id.Text, out id))
            {
                MessageBox.Show("O ID tem de ser numérico");
                return;
            }

            string mensagem;

            bool sucesso = FormGestaoArtigosController.RemoverArtigo(id, out mensagem);
            MessageBox.Show(mensagem);

            if (sucesso)
            {
                CarregarDados();
            }
                
        }

        private void button1Filtrar_Click(object sender, EventArgs e)
        {
            string selecionado = comboBox1Filtrar.SelectedItem.ToString();

            if (selecionado == "Todos")
            {
                dataGridView1.DataSource = FormGestaoArtigosController.ObterArtigos();
            }
            else
            {
                var tipos = FormGestaoTipoArtigosController.ObterTiposArtigos();
                TipoArtigo tipo = tipos.FirstOrDefault(t => t.Tipo == selecionado);

                if (tipo != null)
                    dataGridView1.DataSource = FormGestaoArtigosController.ObterArtigosPorTipo(tipo.Id);
            }
        }
    }
}
