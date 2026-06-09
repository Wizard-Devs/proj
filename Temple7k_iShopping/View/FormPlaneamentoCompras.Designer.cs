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
            this.buttonRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaneamentoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // button2Filtrar
            // 
            this.button2Filtrar.Location = new System.Drawing.Point(231, 31);
            this.button2Filtrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2Filtrar.Name = "button2Filtrar";
            this.button2Filtrar.Size = new System.Drawing.Size(115, 52);
            this.button2Filtrar.TabIndex = 1;
            this.button2Filtrar.Text = "Filtrar";
            this.button2Filtrar.UseVisualStyleBackColor = true;
            this.button2Filtrar.Click += new System.EventHandler(this.button2Filtrar_Click);
            // 
            // button3CriarAlterar
            // 
            this.button3CriarAlterar.Location = new System.Drawing.Point(380, 31);
            this.button3CriarAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3CriarAlterar.Name = "button3CriarAlterar";
            this.button3CriarAlterar.Size = new System.Drawing.Size(115, 52);
            this.button3CriarAlterar.TabIndex = 2;
            this.button3CriarAlterar.Text = "Criar/Alterar";
            this.button3CriarAlterar.UseVisualStyleBackColor = true;
            this.button3CriarAlterar.Click += new System.EventHandler(this.button3CriarAlterar_Click);
            // 
            // dataGridViewPlaneamentoCompras
            // 
            this.dataGridViewPlaneamentoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaneamentoCompras.Location = new System.Drawing.Point(36, 139);
            this.dataGridViewPlaneamentoCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPlaneamentoCompras.Name = "dataGridViewPlaneamentoCompras";
            this.dataGridViewPlaneamentoCompras.RowHeadersWidth = 51;
            this.dataGridViewPlaneamentoCompras.RowTemplate.Height = 24;
            this.dataGridViewPlaneamentoCompras.Size = new System.Drawing.Size(763, 258);
            this.dataGridViewPlaneamentoCompras.TabIndex = 3;
            // 
            // comboBoxFiltrosExistentes
            // 
            this.comboBoxFiltrosExistentes.FormattingEnabled = true;
            this.comboBoxFiltrosExistentes.Location = new System.Drawing.Point(59, 57);
            this.comboBoxFiltrosExistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFiltrosExistentes.Name = "comboBoxFiltrosExistentes";
            this.comboBoxFiltrosExistentes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFiltrosExistentes.TabIndex = 4;
            // 
            // buttonFecharCompras
            // 
            this.buttonFecharCompras.Location = new System.Drawing.Point(684, 31);
            this.buttonFecharCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFecharCompras.Name = "buttonFecharCompras";
            this.buttonFecharCompras.Size = new System.Drawing.Size(115, 52);
            this.buttonFecharCompras.TabIndex = 5;
            this.buttonFecharCompras.Text = "Fechar Compras";
            this.buttonFecharCompras.UseVisualStyleBackColor = true;
            this.buttonFecharCompras.Click += new System.EventHandler(this.buttonFecharCompras_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(534, 31);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(115, 52);
            this.buttonRemover.TabIndex = 6;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // FormPlaneamentoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 428);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonFecharCompras);
            this.Controls.Add(this.comboBoxFiltrosExistentes);
            this.Controls.Add(this.dataGridViewPlaneamentoCompras);
            this.Controls.Add(this.button3CriarAlterar);
            this.Controls.Add(this.button2Filtrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonRemover;
    }
}