namespace Mercadinho.WF
{
    partial class FrmListagemProdutos
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
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaCompra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
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
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.UltimaCompra,
            this.ValorCompra,
            this.Lucro,
            this.ValorVenda,
            this.btnEditar,
            this.btnApagar});
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridProdutos.Location = new System.Drawing.Point(0, 0);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.RowTemplate.Height = 24;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(1772, 299);
            this.gridProdutos.TabIndex = 4;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
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
            this.Autor.DataPropertyName = "Descricao";
            this.Autor.HeaderText = "Descrição";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 200;
            // 
            // UltimaCompra
            // 
            this.UltimaCompra.DataPropertyName = "Ativo";
            this.UltimaCompra.HeaderText = "Ativo";
            this.UltimaCompra.MinimumWidth = 6;
            this.UltimaCompra.Name = "UltimaCompra";
            this.UltimaCompra.ReadOnly = true;
            this.UltimaCompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UltimaCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "ValorCompra";
            this.ValorCompra.HeaderText = "Compra";
            this.ValorCompra.MinimumWidth = 6;
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.ReadOnly = true;
            // 
            // Lucro
            // 
            this.Lucro.DataPropertyName = "Lucro";
            this.Lucro.HeaderText = "Lucro %";
            this.Lucro.MinimumWidth = 6;
            this.Lucro.Name = "Lucro";
            this.Lucro.ReadOnly = true;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "ValorVenda";
            this.ValorVenda.HeaderText = "Venda";
            this.ValorVenda.MinimumWidth = 6;
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
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
            // FrmListagemProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 359);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridProdutos);
            this.MaximizeBox = false;
            this.Name = "FrmListagemProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Listagem de produtos ::..";
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UltimaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}