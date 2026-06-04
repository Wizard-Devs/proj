namespace Temple7k_iShopping.View
{
    partial class FormGestaoOrcamentos
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
            this.textBoxValorOrcamento = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridViewOrcamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // textBoxValorOrcamento
            // 
            this.textBoxValorOrcamento.Location = new System.Drawing.Point(85, 37);
            this.textBoxValorOrcamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorOrcamento.Name = "textBoxValorOrcamento";
            this.textBoxValorOrcamento.Size = new System.Drawing.Size(78, 20);
            this.textBoxValorOrcamento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnAdicionar.Location = new System.Drawing.Point(231, 32);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(74, 26);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnAlterar.Location = new System.Drawing.Point(319, 32);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(56, 26);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnRemover.Location = new System.Drawing.Point(400, 32);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(73, 26);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridViewOrcamentos
            // 
            this.dataGridViewOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrcamentos.Location = new System.Drawing.Point(30, 104);
            this.dataGridViewOrcamentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrcamentos.Name = "dataGridViewOrcamentos";
            this.dataGridViewOrcamentos.RowHeadersWidth = 51;
            this.dataGridViewOrcamentos.RowTemplate.Height = 24;
            this.dataGridViewOrcamentos.Size = new System.Drawing.Size(540, 251);
            this.dataGridViewOrcamentos.TabIndex = 5;
            // 
            // FormGestaoOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewOrcamentos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBoxValorOrcamento);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGestaoOrcamentos";
            this.Text = "FormGestaoOrcamentos";
            this.Load += new System.EventHandler(this.FormGestaoOrcamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrcamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValorOrcamento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dataGridViewOrcamentos;
    }
}