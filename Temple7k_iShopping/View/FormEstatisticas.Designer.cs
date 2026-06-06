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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOrçamentoMes = new System.Windows.Forms.DataGridView();
            this.tabPageApoio = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelOrcamentoSugerido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrçamentoMes)).BeginInit();
            this.tabPageApoio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListagem);
            this.tabControl1.Controls.Add(this.tabPageApoio);
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListagem
            // 
            this.tabPageListagem.Controls.Add(this.label1);
            this.tabPageListagem.Controls.Add(this.dataGridView1);
            this.tabPageListagem.Controls.Add(this.label2);
            this.tabPageListagem.Controls.Add(this.dataGridViewOrçamentoMes);
            this.tabPageListagem.Location = new System.Drawing.Point(4, 22);
            this.tabPageListagem.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageListagem.Name = "tabPageListagem";
            this.tabPageListagem.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageListagem.Size = new System.Drawing.Size(599, 407);
            this.tabPageListagem.TabIndex = 0;
            this.tabPageListagem.Text = "Listagens";
            this.tabPageListagem.UseVisualStyleBackColor = true;
            this.tabPageListagem.Click += new System.EventHandler(this.tabPageListagem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 122);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compras fechadas - artigos previstos e não previstos";
            // 
            // dataGridViewOrçamentoMes
            // 
            this.dataGridViewOrçamentoMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrçamentoMes.Location = new System.Drawing.Point(20, 57);
            this.dataGridViewOrçamentoMes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrçamentoMes.Name = "dataGridViewOrçamentoMes";
            this.dataGridViewOrçamentoMes.RowHeadersWidth = 51;
            this.dataGridViewOrçamentoMes.RowTemplate.Height = 24;
            this.dataGridViewOrçamentoMes.Size = new System.Drawing.Size(552, 122);
            this.dataGridViewOrçamentoMes.TabIndex = 1;
            this.dataGridViewOrçamentoMes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrçamentoMes_CellContentClick);
            // 
            // tabPageApoio
            // 
            this.tabPageApoio.Controls.Add(this.dataGridView2);
            this.tabPageApoio.Controls.Add(this.labelOrcamentoSugerido);
            this.tabPageApoio.Controls.Add(this.label4);
            this.tabPageApoio.Controls.Add(this.label3);
            this.tabPageApoio.Location = new System.Drawing.Point(4, 22);
            this.tabPageApoio.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageApoio.Name = "tabPageApoio";
            this.tabPageApoio.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageApoio.Size = new System.Drawing.Size(599, 407);
            this.tabPageApoio.TabIndex = 1;
            this.tabPageApoio.Text = "Apoio à Decisão";
            this.tabPageApoio.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 222);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(550, 159);
            this.dataGridView2.TabIndex = 3;
            // 
            // labelOrcamentoSugerido
            // 
            this.labelOrcamentoSugerido.AutoSize = true;
            this.labelOrcamentoSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.labelOrcamentoSugerido.Location = new System.Drawing.Point(26, 74);
            this.labelOrcamentoSugerido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrcamentoSugerido.Name = "labelOrcamentoSugerido";
            this.labelOrcamentoSugerido.Size = new System.Drawing.Size(30, 17);
            this.labelOrcamentoSugerido.TabIndex = 2;
            this.labelOrcamentoSugerido.Text = "-- €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(19, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista de compras sugerida para a semana atual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orçamento sugerido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orçamento Mes:";
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 429);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListagem.ResumeLayout(false);
            this.tabPageListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrçamentoMes)).EndInit();
            this.tabPageApoio.ResumeLayout(false);
            this.tabPageApoio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListagem;
        private System.Windows.Forms.TabPage tabPageApoio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrçamentoMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelOrcamentoSugerido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}