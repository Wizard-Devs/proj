namespace Temple7k_iShopping.View
{
    partial class FormEstatisticas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListagem = new System.Windows.Forms.TabPage();
            this.tabPageApoio = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrçamentoMes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOrcamentoSugerido = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageListagem.SuspendLayout();
            this.tabPageApoio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrçamentoMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListagem);
            this.tabControl1.Controls.Add(this.tabPageApoio);
            this.tabControl1.Location = new System.Drawing.Point(-4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListagem
            // 
            this.tabPageListagem.Controls.Add(this.dataGridView1);
            this.tabPageListagem.Controls.Add(this.label2);
            this.tabPageListagem.Controls.Add(this.dataGridViewOrçamentoMes);
            this.tabPageListagem.Controls.Add(this.label1);
            this.tabPageListagem.Location = new System.Drawing.Point(4, 25);
            this.tabPageListagem.Name = "tabPageListagem";
            this.tabPageListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListagem.Size = new System.Drawing.Size(801, 504);
            this.tabPageListagem.TabIndex = 0;
            this.tabPageListagem.Text = "Listagens";
            this.tabPageListagem.UseVisualStyleBackColor = true;
            // 
            // tabPageApoio
            // 
            this.tabPageApoio.Controls.Add(this.dataGridView2);
            this.tabPageApoio.Controls.Add(this.labelOrcamentoSugerido);
            this.tabPageApoio.Controls.Add(this.label4);
            this.tabPageApoio.Controls.Add(this.label3);
            this.tabPageApoio.Location = new System.Drawing.Point(4, 25);
            this.tabPageApoio.Name = "tabPageApoio";
            this.tabPageApoio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApoio.Size = new System.Drawing.Size(801, 504);
            this.tabPageApoio.TabIndex = 1;
            this.tabPageApoio.Text = "Apoio à Decisão";
            this.tabPageApoio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento por mês";
            // 
            // dataGridViewOrçamentoMes
            // 
            this.dataGridViewOrçamentoMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrçamentoMes.Location = new System.Drawing.Point(27, 70);
            this.dataGridViewOrçamentoMes.Name = "dataGridViewOrçamentoMes";
            this.dataGridViewOrçamentoMes.RowHeadersWidth = 51;
            this.dataGridViewOrçamentoMes.RowTemplate.Height = 24;
            this.dataGridViewOrçamentoMes.Size = new System.Drawing.Size(736, 150);
            this.dataGridViewOrçamentoMes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(24, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compras fechadas - artigos previstos e não previstos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orçamento sugerido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista de compras sugerida para a semana atual";
            // 
            // labelOrcamentoSugerido
            // 
            this.labelOrcamentoSugerido.AutoSize = true;
            this.labelOrcamentoSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.labelOrcamentoSugerido.Location = new System.Drawing.Point(35, 91);
            this.labelOrcamentoSugerido.Name = "labelOrcamentoSugerido";
            this.labelOrcamentoSugerido.Size = new System.Drawing.Size(37, 22);
            this.labelOrcamentoSugerido.TabIndex = 2;
            this.labelOrcamentoSugerido.Text = "-- €";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 273);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(734, 196);
            this.dataGridView2.TabIndex = 3;
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.tabControl1.ResumeLayout(false);
            this.tabPageListagem.ResumeLayout(false);
            this.tabPageListagem.PerformLayout();
            this.tabPageApoio.ResumeLayout(false);
            this.tabPageApoio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrçamentoMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListagem;
        private System.Windows.Forms.TabPage tabPageApoio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrçamentoMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelOrcamentoSugerido;
        private System.Windows.Forms.Label label4;
    }
}