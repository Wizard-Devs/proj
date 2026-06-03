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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1FiltrosExistentes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2Filtrar
            // 
            this.button2Filtrar.Location = new System.Drawing.Point(224, 56);
            this.button2Filtrar.Name = "button2Filtrar";
            this.button2Filtrar.Size = new System.Drawing.Size(115, 52);
            this.button2Filtrar.TabIndex = 1;
            this.button2Filtrar.Text = "Filtrar";
            this.button2Filtrar.UseVisualStyleBackColor = true;
            // 
            // button3CriarAlterar
            // 
            this.button3CriarAlterar.Location = new System.Drawing.Point(380, 56);
            this.button3CriarAlterar.Name = "button3CriarAlterar";
            this.button3CriarAlterar.Size = new System.Drawing.Size(115, 52);
            this.button3CriarAlterar.TabIndex = 2;
            this.button3CriarAlterar.Text = "Criar/Alterar";
            this.button3CriarAlterar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 163);
            this.dataGridView1.TabIndex = 3;
            // 
            // comboBox1FiltrosExistentes
            // 
            this.comboBox1FiltrosExistentes.FormattingEnabled = true;
            this.comboBox1FiltrosExistentes.Location = new System.Drawing.Point(59, 71);
            this.comboBox1FiltrosExistentes.Name = "comboBox1FiltrosExistentes";
            this.comboBox1FiltrosExistentes.Size = new System.Drawing.Size(121, 24);
            this.comboBox1FiltrosExistentes.TabIndex = 4;
            // 
            // FormPlaneamentoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 353);
            this.Controls.Add(this.comboBox1FiltrosExistentes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3CriarAlterar);
            this.Controls.Add(this.button2Filtrar);
            this.Name = "FormPlaneamentoCompras";
            this.Text = "FormPlaneamentoCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2Filtrar;
        private System.Windows.Forms.Button button3CriarAlterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1FiltrosExistentes;
    }
}