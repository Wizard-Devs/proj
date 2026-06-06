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

namespace Temple7k_iShopping.View
{
    public partial class FormGestaoUtilizadores : Form
    {
        public FormGestaoUtilizadores()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            dataGridView1.DataSource = FormGestaoUtilizadorController.ObterUtilizadores();
        }

        private void LimparCampos()
        {
            textBox1Username.Text = "";
            textBox2Password.Text = "";
            textBox3ConfirmPass.Text = "";
        }

        private void FormGestaoUtilizadores_Load(object sender, EventArgs e)
        {
            CarregarDados();
            textBox2Password.PasswordChar = '*';
            textBox3ConfirmPass.PasswordChar = '*';
        }

        private void button1Criar_Click(object sender, EventArgs e)
        {
            string message = "";
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;
            string confirmPassword = textBox3ConfirmPass.Text;

            bool addUser = FormGestaoUtilizadorController.AdicionarUtilizador(username, password, confirmPassword, out message);
            MessageBox.Show(message);

            if (addUser)
            {
                CarregarDados();
                LimparCampos();
            }

        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                Utilizador user = (Utilizador)dataGridView1.CurrentRow.DataBoundItem;
                textBox1Username.Text = user.Username;
                textBox2Password.Text = user.Password;
                textBox1Id.Text = user.Id.ToString();
            }
        }

        private void button2Alterar_Click(object sender, EventArgs e)
        {
            int id;
            string message = "";
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;
            string confirmPassword = textBox3ConfirmPass.Text;

            if (!int.TryParse(textBox1Id.Text, out id))
            {
                MessageBox.Show("O ID deve ser numérico");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Os campos devem estar preenchido");
                return;
            }

            bool ok = FormGestaoUtilizadorController.AlterarUtilizador(id, username, password, confirmPassword, out message);
            MessageBox.Show(message);

            if (ok)
            {
                LimparCampos();
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
            bool ok = FormGestaoUtilizadorController.RemoverUtilizador(id, out mensagem);

            MessageBox.Show(mensagem);

            if (ok)
            {
                LimparCampos();
                CarregarDados();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
