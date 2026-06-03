namespace Temple7k_iShopping
{
    partial class FormCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1Adicionar = new System.Windows.Forms.Button();
            this.button3Remover = new System.Windows.Forms.Button();
            this.button2Alterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1ListaAdquiridosOuNao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.Location = new System.Drawing.Point(44, 32);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(115, 52);
            this.button1Adicionar.TabIndex = 14;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = true;
            // 
            // button3Remover
            // 
            this.button3Remover.Location = new System.Drawing.Point(343, 32);
            this.button3Remover.Name = "button3Remover";
            this.button3Remover.Size = new System.Drawing.Size(115, 52);
            this.button3Remover.TabIndex = 13;
            this.button3Remover.Text = "Remover";
            this.button3Remover.UseVisualStyleBackColor = true;
            // 
            // button2Alterar
            // 
            this.button2Alterar.Location = new System.Drawing.Point(187, 32);
            this.button2Alterar.Name = "button2Alterar";
            this.button2Alterar.Size = new System.Drawing.Size(115, 52);
            this.button2Alterar.TabIndex = 12;
            this.button2Alterar.Text = "Alterar";
            this.button2Alterar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 208);
            this.dataGridView1.TabIndex = 15;
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(594, 118);
            this.textBox1Username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(232, 22);
            this.textBox1Username.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantidade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preço Unitário:";
            // 
            // comboBox1ListaAdquiridosOuNao
            // 
            this.comboBox1ListaAdquiridosOuNao.FormattingEnabled = true;
            this.comboBox1ListaAdquiridosOuNao.Location = new System.Drawing.Point(541, 274);
            this.comboBox1ListaAdquiridosOuNao.Name = "comboBox1ListaAdquiridosOuNao";
            this.comboBox1ListaAdquiridosOuNao.Size = new System.Drawing.Size(205, 24);
            this.comboBox1ListaAdquiridosOuNao.TabIndex = 20;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 382);
            this.Controls.Add(this.comboBox1ListaAdquiridosOuNao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.button3Remover);
            this.Controls.Add(this.button2Alterar);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.Button button3Remover;
        private System.Windows.Forms.Button button2Alterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1ListaAdquiridosOuNao;
    }
}