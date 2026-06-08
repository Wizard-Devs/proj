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
            this.textBox1Artigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Filtrar = new System.Windows.Forms.Button();
            this.button3Remover = new System.Windows.Forms.Button();
            this.button2Alterar = new System.Windows.Forms.Button();
            this.button1Adicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2TipoArt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1Id = new System.Windows.Forms.TextBox();
            this.comboBox1Filtrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Artigo
            // 
            this.textBox1Artigo.Location = new System.Drawing.Point(112, 265);
            this.textBox1Artigo.Name = "textBox1Artigo";
            this.textBox1Artigo.Size = new System.Drawing.Size(175, 20);
            this.textBox1Artigo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artigo:";
            // 
            // button1Filtrar
            // 
            this.button1Filtrar.BackColor = System.Drawing.SystemColors.Control;
            this.button1Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button1Filtrar.Location = new System.Drawing.Point(282, 7);
            this.button1Filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.button1Filtrar.Name = "button1Filtrar";
            this.button1Filtrar.Size = new System.Drawing.Size(69, 32);
            this.button1Filtrar.TabIndex = 7;
            this.button1Filtrar.Text = "Filtrar";
            this.button1Filtrar.UseVisualStyleBackColor = false;
            this.button1Filtrar.Click += new System.EventHandler(this.button1Filtrar_Click);
            // 
            // button3Remover
            // 
            this.button3Remover.BackColor = System.Drawing.SystemColors.Control;
            this.button3Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button3Remover.Location = new System.Drawing.Point(277, 196);
            this.button3Remover.Margin = new System.Windows.Forms.Padding(2);
            this.button3Remover.Name = "button3Remover";
            this.button3Remover.Size = new System.Drawing.Size(74, 32);
            this.button3Remover.TabIndex = 10;
            this.button3Remover.Text = "Remover";
            this.button3Remover.UseVisualStyleBackColor = false;
            this.button3Remover.Click += new System.EventHandler(this.button3Remover_Click);
            // 
            // button2Alterar
            // 
            this.button2Alterar.BackColor = System.Drawing.SystemColors.Control;
            this.button2Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2Alterar.Location = new System.Drawing.Point(149, 196);
            this.button2Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.button2Alterar.Name = "button2Alterar";
            this.button2Alterar.Size = new System.Drawing.Size(74, 32);
            this.button2Alterar.TabIndex = 9;
            this.button2Alterar.Text = "Alterar";
            this.button2Alterar.UseVisualStyleBackColor = false;
            this.button2Alterar.Click += new System.EventHandler(this.button2Alterar_Click);
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.BackColor = System.Drawing.SystemColors.Control;
            this.button1Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1Adicionar.Location = new System.Drawing.Point(12, 196);
            this.button1Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(84, 32);
            this.button1Adicionar.TabIndex = 8;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = false;
            this.button1Adicionar.Click += new System.EventHandler(this.button1Adicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 139);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtrar por artigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(-3, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo de Artigo:";
            // 
            // comboBox2TipoArt
            // 
            this.comboBox2TipoArt.FormattingEnabled = true;
            this.comboBox2TipoArt.Location = new System.Drawing.Point(112, 290);
            this.comboBox2TipoArt.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2TipoArt.Name = "comboBox2TipoArt";
            this.comboBox2TipoArt.Size = new System.Drawing.Size(175, 21);
            this.comboBox2TipoArt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Id Artigo:";
            // 
            // textBox1Id
            // 
            this.textBox1Id.Location = new System.Drawing.Point(112, 242);
            this.textBox1Id.Name = "textBox1Id";
            this.textBox1Id.Size = new System.Drawing.Size(40, 20);
            this.textBox1Id.TabIndex = 18;
            // 
            // comboBox1Filtrar
            // 
            this.comboBox1Filtrar.FormattingEnabled = true;
            this.comboBox1Filtrar.Location = new System.Drawing.Point(137, 12);
            this.comboBox1Filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1Filtrar.Name = "comboBox1Filtrar";
            this.comboBox1Filtrar.Size = new System.Drawing.Size(141, 21);
            this.comboBox1Filtrar.TabIndex = 19;
            // 
            // FormGestaoArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 337);
            this.Controls.Add(this.comboBox1Filtrar);
            this.Controls.Add(this.textBox1Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2TipoArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3Remover);
            this.Controls.Add(this.button2Alterar);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.button1Filtrar);
            this.Controls.Add(this.textBox1Artigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGestaoArtigos";
            this.Text = "FormGestaoArtigos";
            this.Load += new System.EventHandler(this.FormGestaoArtigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Artigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Filtrar;
        private System.Windows.Forms.Button button3Remover;
        private System.Windows.Forms.Button button2Alterar;
        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2TipoArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1Id;
        private System.Windows.Forms.ComboBox comboBox1Filtrar;
    }
}