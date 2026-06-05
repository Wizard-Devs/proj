namespace Temple7k_iShopping
{
    partial class FormPlaneamentoCompras
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
            this.button2Filtrar = new System.Windows.Forms.Button();
            this.button3CriarAlterar = new System.Windows.Forms.Button();
            this.dataGridViewPlaneamentoCompras = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltrosExistentes = new System.Windows.Forms.ComboBox();
            this.buttonFecharCompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaneamentoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // button2Filtrar
            // 
            this.button2Filtrar.Location = new System.Drawing.Point(173, 25);
            this.button2Filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.button2Filtrar.Name = "button2Filtrar";
            this.button2Filtrar.Size = new System.Drawing.Size(86, 42);
            this.button2Filtrar.TabIndex = 1;
            this.button2Filtrar.Text = "Filtrar";
            this.button2Filtrar.UseVisualStyleBackColor = true;
            this.button2Filtrar.Click += new System.EventHandler(this.button2Filtrar_Click);
            // 
            // button3CriarAlterar
            // 
            this.button3CriarAlterar.Location = new System.Drawing.Point(285, 25);
            this.button3CriarAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.button3CriarAlterar.Name = "button3CriarAlterar";
            this.button3CriarAlterar.Size = new System.Drawing.Size(86, 42);
            this.button3CriarAlterar.TabIndex = 2;
            this.button3CriarAlterar.Text = "Criar/Alterar";
            this.button3CriarAlterar.UseVisualStyleBackColor = true;
            this.button3CriarAlterar.Click += new System.EventHandler(this.button3CriarAlterar_Click);
            // 
            // dataGridViewPlaneamentoCompras
            // 
            this.dataGridViewPlaneamentoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaneamentoCompras.Location = new System.Drawing.Point(27, 113);
            this.dataGridViewPlaneamentoCompras.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPlaneamentoCompras.Name = "dataGridViewPlaneamentoCompras";
            this.dataGridViewPlaneamentoCompras.RowHeadersWidth = 51;
            this.dataGridViewPlaneamentoCompras.RowTemplate.Height = 24;
            this.dataGridViewPlaneamentoCompras.Size = new System.Drawing.Size(496, 151);
            this.dataGridViewPlaneamentoCompras.TabIndex = 3;
            // 
            // comboBoxFiltrosExistentes
            // 
            this.comboBoxFiltrosExistentes.FormattingEnabled = true;
            this.comboBoxFiltrosExistentes.Location = new System.Drawing.Point(44, 46);
            this.comboBoxFiltrosExistentes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFiltrosExistentes.Name = "comboBoxFiltrosExistentes";
            this.comboBoxFiltrosExistentes.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFiltrosExistentes.TabIndex = 4;
            // 
            // buttonFecharCompras
            // 
            this.buttonFecharCompras.Location = new System.Drawing.Point(402, 25);
            this.buttonFecharCompras.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFecharCompras.Name = "buttonFecharCompras";
            this.buttonFecharCompras.Size = new System.Drawing.Size(86, 42);
            this.buttonFecharCompras.TabIndex = 5;
            this.buttonFecharCompras.Text = "Fechar Compras";
            this.buttonFecharCompras.UseVisualStyleBackColor = true;
            this.buttonFecharCompras.Click += new System.EventHandler(this.buttonFecharCompras_Click);
            // 
            // FormPlaneamentoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 287);
            this.Controls.Add(this.buttonFecharCompras);
            this.Controls.Add(this.comboBoxFiltrosExistentes);
            this.Controls.Add(this.dataGridViewPlaneamentoCompras);
            this.Controls.Add(this.button3CriarAlterar);
            this.Controls.Add(this.button2Filtrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPlaneamentoCompras";
            this.Text = "FormPlaneamentoCompras";
            this.Load += new System.EventHandler(this.FormPlaneamentoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaneamentoCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2Filtrar;
        private System.Windows.Forms.Button button3CriarAlterar;
        private System.Windows.Forms.DataGridView dataGridViewPlaneamentoCompras;
        private System.Windows.Forms.ComboBox comboBoxFiltrosExistentes;
        private System.Windows.Forms.Button buttonFecharCompras;
    }
}