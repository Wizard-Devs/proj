namespace Temple7k_iShopping
{
    partial class FormGestaoArtigos
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
            this.button1Filtrar = new System.Windows.Forms.Button();
            this.button3Remover = new System.Windows.Forms.Button();
            this.button2Alterar = new System.Windows.Forms.Button();
            this.button1Adicionar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(86, 14);
            this.textBox1Username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(232, 22);
            this.textBox1Username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artigo:";
            // 
            // button1Filtrar
            // 
            this.button1Filtrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1Filtrar.Location = new System.Drawing.Point(691, 12);
            this.button1Filtrar.Name = "button1Filtrar";
            this.button1Filtrar.Size = new System.Drawing.Size(92, 40);
            this.button1Filtrar.TabIndex = 7;
            this.button1Filtrar.Text = "Filtrar";
            this.button1Filtrar.UseVisualStyleBackColor = false;
            // 
            // button3Remover
            // 
            this.button3Remover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button3Remover.Location = new System.Drawing.Point(461, 57);
            this.button3Remover.Name = "button3Remover";
            this.button3Remover.Size = new System.Drawing.Size(92, 40);
            this.button3Remover.TabIndex = 10;
            this.button3Remover.Text = "Remover";
            this.button3Remover.UseVisualStyleBackColor = false;
            // 
            // button2Alterar
            // 
            this.button2Alterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2Alterar.Location = new System.Drawing.Point(342, 57);
            this.button2Alterar.Name = "button2Alterar";
            this.button2Alterar.Size = new System.Drawing.Size(94, 40);
            this.button2Alterar.TabIndex = 9;
            this.button2Alterar.Text = "Alterar";
            this.button2Alterar.UseVisualStyleBackColor = false;
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1Adicionar.Location = new System.Drawing.Point(224, 57);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(94, 40);
            this.button1Adicionar.TabIndex = 8;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 217);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(343, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtrar por:";
            // 
            // FormGestaoArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3Remover);
            this.Controls.Add(this.button2Alterar);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.button1Filtrar);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.label1);
            this.Name = "FormGestaoArtigos";
            this.Text = "FormGestaoArtigos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Filtrar;
        private System.Windows.Forms.Button button3Remover;
        private System.Windows.Forms.Button button2Alterar;
        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}