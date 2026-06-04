namespace Temple7k_iShopping
{
    partial class Form_gestao_tipos_de_artigo
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1Adicionar = new System.Windows.Forms.Button();
            this.button2Alterar = new System.Windows.Forms.Button();
            this.button3Remover = new System.Windows.Forms.Button();
            this.textBox1TipoArtigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Artigo:";
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Adicionar.Location = new System.Drawing.Point(14, 57);
            this.button1Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(80, 32);
            this.button1Adicionar.TabIndex = 1;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = false;
            this.button1Adicionar.Click += new System.EventHandler(this.button1Adicionar_Click);
            // 
            // button2Alterar
            // 
            this.button2Alterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2Alterar.Location = new System.Drawing.Point(14, 125);
            this.button2Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.button2Alterar.Name = "button2Alterar";
            this.button2Alterar.Size = new System.Drawing.Size(80, 32);
            this.button2Alterar.TabIndex = 2;
            this.button2Alterar.Text = "Alterar";
            this.button2Alterar.UseVisualStyleBackColor = false;
            // 
            // button3Remover
            // 
            this.button3Remover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button3Remover.Location = new System.Drawing.Point(14, 194);
            this.button3Remover.Margin = new System.Windows.Forms.Padding(2);
            this.button3Remover.Name = "button3Remover";
            this.button3Remover.Size = new System.Drawing.Size(80, 32);
            this.button3Remover.TabIndex = 3;
            this.button3Remover.Text = "Remover";
            this.button3Remover.UseVisualStyleBackColor = false;
            // 
            // textBox1TipoArtigo
            // 
            this.textBox1TipoArtigo.Location = new System.Drawing.Point(130, 11);
            this.textBox1TipoArtigo.Name = "textBox1TipoArtigo";
            this.textBox1TipoArtigo.Size = new System.Drawing.Size(285, 20);
            this.textBox1TipoArtigo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 170);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form_gestao_tipos_de_artigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 246);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1TipoArtigo);
            this.Controls.Add(this.button3Remover);
            this.Controls.Add(this.button2Alterar);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_gestao_tipos_de_artigo";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.Button button2Alterar;
        private System.Windows.Forms.Button button3Remover;
        private System.Windows.Forms.TextBox textBox1TipoArtigo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}