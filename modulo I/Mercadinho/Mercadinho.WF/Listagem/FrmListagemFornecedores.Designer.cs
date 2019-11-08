namespace Mercadinho.WF
{
    partial class FrmListagemFornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gridFornecedores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(0, 305);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 49);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridFornecedores
            // 
            this.gridFornecedores.AllowUserToAddRows = false;
            this.gridFornecedores.AllowUserToDeleteRows = false;
            this.gridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Ativo,
            this.DataRecebimento,
            this.btnEditar,
            this.btnApagar});
            this.gridFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridFornecedores.Location = new System.Drawing.Point(0, 0);
            this.gridFornecedores.Name = "gridFornecedores";
            this.gridFornecedores.ReadOnly = true;
            this.gridFornecedores.RowHeadersWidth = 51;
            this.gridFornecedores.RowTemplate.Height = 24;
            this.gridFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFornecedores.Size = new System.Drawing.Size(1496, 299);
            this.gridFornecedores.TabIndex = 4;
            this.gridFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedores_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Codigo";
            this.Titulo.HeaderText = "Código";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 200;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Nome";
            this.Autor.HeaderText = "Nome";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 200;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.MinimumWidth = 6;
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 125;
            // 
            // DataRecebimento
            // 
            this.DataRecebimento.DataPropertyName = "DataRecebimento";
            this.DataRecebimento.HeaderText = "Data Recebimento";
            this.DataRecebimento.MinimumWidth = 6;
            this.DataRecebimento.Name = "DataRecebimento";
            this.DataRecebimento.ReadOnly = true;
            this.DataRecebimento.Width = 200;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 125;
            // 
            // btnApagar
            // 
            this.btnApagar.HeaderText = "Apagar";
            this.btnApagar.MinimumWidth = 6;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.ReadOnly = true;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseColumnTextForButtonValue = true;
            this.btnApagar.Width = 125;
            // 
            // FrmListagemFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 360);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridFornecedores);
            this.MaximizeBox = false;
            this.Name = "FrmListagemFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Listagem de Fornecedores ::..";
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridFornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecebimento;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}