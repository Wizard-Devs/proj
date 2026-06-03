namespace Temple7k_iShopping
{
    partial class FormEstatisticasListagens
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
            this.dataGridView1OrcamentoMes = new System.Windows.Forms.DataGridView();
            this.dataGridView1ComprasFechadas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1OrcamentoMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1ComprasFechadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Orçamento por Mês:";
            // 
            // dataGridView1OrcamentoMes
            // 
            this.dataGridView1OrcamentoMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1OrcamentoMes.Location = new System.Drawing.Point(30, 79);
            this.dataGridView1OrcamentoMes.Name = "dataGridView1OrcamentoMes";
            this.dataGridView1OrcamentoMes.RowHeadersWidth = 51;
            this.dataGridView1OrcamentoMes.RowTemplate.Height = 24;
            this.dataGridView1OrcamentoMes.Size = new System.Drawing.Size(475, 150);
            this.dataGridView1OrcamentoMes.TabIndex = 18;
            // 
            // dataGridView1ComprasFechadas
            // 
            this.dataGridView1ComprasFechadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1ComprasFechadas.Location = new System.Drawing.Point(30, 336);
            this.dataGridView1ComprasFechadas.Name = "dataGridView1ComprasFechadas";
            this.dataGridView1ComprasFechadas.RowHeadersWidth = 51;
            this.dataGridView1ComprasFechadas.RowTemplate.Height = 24;
            this.dataGridView1ComprasFechadas.Size = new System.Drawing.Size(475, 150);
            this.dataGridView1ComprasFechadas.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Compras fechadas -  artigos previstos vs  não previstos";
            // 
            // FormEstatisticasListagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 516);
            this.Controls.Add(this.dataGridView1ComprasFechadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1OrcamentoMes);
            this.Controls.Add(this.label1);
            this.Name = "FormEstatisticasListagens";
            this.Text = "FormEstatisticasListagens";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1OrcamentoMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1ComprasFechadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1OrcamentoMes;
        private System.Windows.Forms.DataGridView dataGridView1ComprasFechadas;
        private System.Windows.Forms.Label label2;
    }
}