namespace WF_Livros
{
    partial class frmManutencaoLivro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroPaginas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataLancamento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(347, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(184, 51);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(238, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(184, 98);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(238, 22);
            this.txtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Título";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(184, 138);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(238, 22);
            this.txtAutor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Páginas";
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(184, 176);
            this.txtNumeroPaginas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(138, 22);
            this.txtNumeroPaginas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dt. Lançamento";
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataLancamento.Location = new System.Drawing.Point(184, 216);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(138, 22);
            this.txtDataLancamento.TabIndex = 11;
            // 
            // frmManutencaoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 313);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmManutencaoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Manutenção de Livro ::..";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtNumeroPaginas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDataLancamento;
    }
}

