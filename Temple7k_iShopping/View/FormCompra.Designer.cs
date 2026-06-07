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
            this.dataGridViewCompra = new System.Windows.Forms.DataGridView();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxArtigos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTerminarCompra = new System.Windows.Forms.Button();
            this.richTextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOrcamentoAtual = new System.Windows.Forms.Label();
            this.labelNomeCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Adicionar
            // 
            this.button1Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.button1Adicionar.Location = new System.Drawing.Point(23, 523);
            this.button1Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.button1Adicionar.Name = "button1Adicionar";
            this.button1Adicionar.Size = new System.Drawing.Size(86, 42);
            this.button1Adicionar.TabIndex = 14;
            this.button1Adicionar.Text = "Adicionar";
            this.button1Adicionar.UseVisualStyleBackColor = true;
            this.button1Adicionar.Click += new System.EventHandler(this.button1Adicionar_Click);
            // 
            // button3Remover
            // 
            this.button3Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.button3Remover.Location = new System.Drawing.Point(257, 523);
            this.button3Remover.Margin = new System.Windows.Forms.Padding(2);
            this.button3Remover.Name = "button3Remover";
            this.button3Remover.Size = new System.Drawing.Size(86, 42);
            this.button3Remover.TabIndex = 13;
            this.button3Remover.Text = "Remover";
            this.button3Remover.UseVisualStyleBackColor = true;
            this.button3Remover.Click += new System.EventHandler(this.button3Remover_Click);
            // 
            // button2Alterar
            // 
            this.button2Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.button2Alterar.Location = new System.Drawing.Point(138, 523);
            this.button2Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.button2Alterar.Name = "button2Alterar";
            this.button2Alterar.Size = new System.Drawing.Size(86, 42);
            this.button2Alterar.TabIndex = 12;
            this.button2Alterar.Text = "Alterar";
            this.button2Alterar.UseVisualStyleBackColor = true;
            this.button2Alterar.Click += new System.EventHandler(this.button2Alterar_Click);
            // 
            // dataGridViewCompra
            // 
            this.dataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompra.Location = new System.Drawing.Point(23, 267);
            this.dataGridViewCompra.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCompra.Name = "dataGridViewCompra";
            this.dataGridViewCompra.RowHeadersWidth = 51;
            this.dataGridViewCompra.RowTemplate.Height = 24;
            this.dataGridViewCompra.Size = new System.Drawing.Size(760, 234);
            this.dataGridViewCompra.TabIndex = 15;
            this.dataGridViewCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompra_CellContentClick);
            this.dataGridViewCompra.SelectionChanged += new System.EventHandler(this.dataGridViewCompra_SelectionChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(217, 81);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(175, 20);
            this.textBoxQuantidade.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.Location = new System.Drawing.Point(214, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantidade:";
            // 
            // textBoxPrecoUnitario
            // 
            this.textBoxPrecoUnitario.Location = new System.Drawing.Point(434, 81);
            this.textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            this.textBoxPrecoUnitario.Size = new System.Drawing.Size(175, 20);
            this.textBoxPrecoUnitario.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(431, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preço Unitário:";
            // 
            // comboBoxArtigos
            // 
            this.comboBoxArtigos.FormattingEnabled = true;
            this.comboBoxArtigos.Location = new System.Drawing.Point(23, 81);
            this.comboBoxArtigos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArtigos.Name = "comboBoxArtigos";
            this.comboBoxArtigos.Size = new System.Drawing.Size(155, 21);
            this.comboBoxArtigos.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Artigos:";
            // 
            // buttonTerminarCompra
            // 
            this.buttonTerminarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.buttonTerminarCompra.Location = new System.Drawing.Point(697, 523);
            this.buttonTerminarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTerminarCompra.Name = "buttonTerminarCompra";
            this.buttonTerminarCompra.Size = new System.Drawing.Size(86, 42);
            this.buttonTerminarCompra.TabIndex = 22;
            this.buttonTerminarCompra.Text = "Terminar Compra";
            this.buttonTerminarCompra.UseVisualStyleBackColor = true;
            this.buttonTerminarCompra.Click += new System.EventHandler(this.buttonTerminarCompra_Click);
            // 
            // richTextBoxObservacao
            // 
            this.richTextBoxObservacao.Location = new System.Drawing.Point(23, 172);
            this.richTextBoxObservacao.Name = "richTextBoxObservacao";
            this.richTextBoxObservacao.Size = new System.Drawing.Size(760, 69);
            this.richTextBoxObservacao.TabIndex = 23;
            this.richTextBoxObservacao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Observação:";
            // 
            // labelOrcamentoAtual
            // 
            this.labelOrcamentoAtual.AutoSize = true;
            this.labelOrcamentoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.labelOrcamentoAtual.Location = new System.Drawing.Point(716, 81);
            this.labelOrcamentoAtual.Name = "labelOrcamentoAtual";
            this.labelOrcamentoAtual.Size = new System.Drawing.Size(30, 17);
            this.labelOrcamentoAtual.TabIndex = 25;
            this.labelOrcamentoAtual.Text = "-- €";
            // 
            // labelNomeCompra
            // 
            this.labelNomeCompra.AutoSize = true;
            this.labelNomeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.labelNomeCompra.Location = new System.Drawing.Point(20, 21);
            this.labelNomeCompra.Name = "labelNomeCompra";
            this.labelNomeCompra.Size = new System.Drawing.Size(46, 17);
            this.labelNomeCompra.TabIndex = 26;
            this.labelNomeCompra.Text = "label5";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 583);
            this.Controls.Add(this.labelNomeCompra);
            this.Controls.Add(this.labelOrcamentoAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxObservacao);
            this.Controls.Add(this.buttonTerminarCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxArtigos);
            this.Controls.Add(this.textBoxPrecoUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCompra);
            this.Controls.Add(this.button1Adicionar);
            this.Controls.Add(this.button3Remover);
            this.Controls.Add(this.button2Alterar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Adicionar;
        private System.Windows.Forms.Button button3Remover;
        private System.Windows.Forms.Button button2Alterar;
        private System.Windows.Forms.DataGridView dataGridViewCompra;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecoUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxArtigos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTerminarCompra;
        private System.Windows.Forms.RichTextBox richTextBoxObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOrcamentoAtual;
        private System.Windows.Forms.Label labelNomeCompra;
    }
}