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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;
            string message;

            bool sucess = FormLoginController.Authenticate(username, password, out message);

            MessageBox.Show(message);

            if (sucess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
