namespace Mercadinho.WF
{
    partial class FrmRecebimento
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
            this.cmbFornecedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.NumericUpDown();
            this.btnEfetivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFornecedores
            // 
            this.cmbFornecedores.FormattingEnabled = true;
            this.cmbFornecedores.Location = new System.Drawing.Point(99, 24);
            this.cmbFornecedores.Name = "cmbFornecedores";
            this.cmbFornecedores.Size = new System.Drawing.Size(426, 24);
            this.cmbFornecedores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fronecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto:";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(99, 68);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(251, 24);
            this.cmbProdutos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(417, 69);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(108, 22);
            this.txtQtde.TabIndex = 5;
            // 
            // btnEfetivar
            // 
            this.btnEfetivar.Location = new System.Drawing.Point(414, 106);
            this.btnEfetivar.Name = "btnEfetivar";
            this.btnEfetivar.Size = new System.Drawing.Size(114, 34);
            this.btnEfetivar.TabIndex = 6;
            this.btnEfetivar.Text = "Efetivar";
            this.btnEfetivar.UseVisualStyleBackColor = true;
            this.btnEfetivar.Click += new System.EventHandler(this.btnEfetivar_Click);
            // 
            // FrmRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 150);
            this.Controls.Add(this.btnEfetivar);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFornecedores);
            this.MaximizeBox = false;
            this.Name = "FrmRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Recebimento ::..";
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQtde;
        private System.Windows.Forms.Button btnEfetivar;
    }
}