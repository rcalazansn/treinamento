namespace Mercadinho.WF
{
    partial class FrmVenda
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
            this.btnEfetivar = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorTotalVenda = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotalProdutos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEfetivar
            // 
            this.btnEfetivar.Location = new System.Drawing.Point(16, 260);
            this.btnEfetivar.Name = "btnEfetivar";
            this.btnEfetivar.Size = new System.Drawing.Size(510, 34);
            this.btnEfetivar.TabIndex = 11;
            this.btnEfetivar.Text = "Efetivar";
            this.btnEfetivar.UseVisualStyleBackColor = true;
            this.btnEfetivar.Click += new System.EventHandler(this.btnEfetivar_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(418, 56);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(108, 22);
            this.txtQtde.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Qtde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produto:";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(100, 55);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(251, 24);
            this.cmbProdutos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(100, 12);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(426, 24);
            this.cmbClientes.TabIndex = 12;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(372, 93);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(154, 40);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorTotalVenda);
            this.groupBox1.Controls.Add(this.txtValorDesconto);
            this.groupBox1.Controls.Add(this.txtValorTotalProdutos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 116);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "valores";
            // 
            // txtValorTotalVenda
            // 
            this.txtValorTotalVenda.Location = new System.Drawing.Point(344, 78);
            this.txtValorTotalVenda.Name = "txtValorTotalVenda";
            this.txtValorTotalVenda.Size = new System.Drawing.Size(141, 22);
            this.txtValorTotalVenda.TabIndex = 27;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(344, 49);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(141, 22);
            this.txtValorDesconto.TabIndex = 26;
            // 
            // txtValorTotalProdutos
            // 
            this.txtValorTotalProdutos.Location = new System.Drawing.Point(344, 21);
            this.txtValorTotalProdutos.Name = "txtValorTotalProdutos";
            this.txtValorTotalProdutos.Size = new System.Drawing.Size(141, 22);
            this.txtValorTotalProdutos.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Desconto %:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Produto:";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.btnEfetivar);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProdutos);
            this.MaximizeBox = false;
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Venda ::..";
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEfetivar;
        private System.Windows.Forms.NumericUpDown txtQtde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorTotalVenda;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.TextBox txtValorTotalProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}