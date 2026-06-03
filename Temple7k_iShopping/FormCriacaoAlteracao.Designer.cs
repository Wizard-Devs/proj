namespace Temple7k_iShopping
{
    partial class FormCriacaoAlteracao
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
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3Remover = new System.Windows.Forms.Button();
            this.button2Alterar = new System.Windows.Forms.Button();
            this.button1Adicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(159, 62);
            this.textBox1Username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(232, 22);
            this.textBox1Username.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artigo:";
            // 
            // button3Remover
            // 
            this.button3Remover.Location = new System.Drawing.Point(335, 123);
            this.button3Remover.Name = "button3Remover";
            this.button3Remover.Size = new System.Drawing.Size(115, 52);
            this.button3Remover.TabIndex = 10;
            this.button3Remover.Text = "Remover";
            this.button3Remover.UseVisualStyleBackColor = true;
            // 
            // button2Alterar
            // 
            this.button2Alterar.Location = new System.Drawing.Point(179, 123);
            this.button2Alterar.Name = "button2Alterar";
            this.button2Alterar.Size = new System.Drawing.Size(115, 52);
            this.button2Alterar.TabIndex = 9;
            this.button2Alterar.Text = "Alterar";
            this.button2Alterar.UseVisualStyleBackColor = true;
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.Location = new System.Drawing.Point(36, 123);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(115, 52);
            this.button1Adicionar.TabIndex = 11;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 163);
            this.dataGridView1.TabIndex = 12;
            // 
            // FormCriacaoAlteracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.button3Remover);
            this.Controls.Add(this.button2Alterar);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.label1);
            this.Name = "FormCriacaoAlteracao";
            this.Text = "FormCriacaoAlteracao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3Remover;
        private System.Windows.Forms.Button button2Alterar;
        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}