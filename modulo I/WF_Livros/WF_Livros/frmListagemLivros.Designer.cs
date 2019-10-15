namespace WF_Livros
{
    partial class frmListagemLivros
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemLivros));
            this.dgListagemLivro = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgListagemLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListagemLivro
            // 
            this.dgListagemLivro.AllowUserToAddRows = false;
            this.dgListagemLivro.AllowUserToDeleteRows = false;
            this.dgListagemLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListagemLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.DataLancamento,
            this.numeroPaginas,
            this.btnEditar,
            this.btnApagar});
            this.dgListagemLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgListagemLivro.Location = new System.Drawing.Point(0, 0);
            this.dgListagemLivro.Name = "dgListagemLivro";
            this.dgListagemLivro.ReadOnly = true;
            this.dgListagemLivro.RowHeadersWidth = 51;
            this.dgListagemLivro.RowTemplate.Height = 24;
            this.dgListagemLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListagemLivro.Size = new System.Drawing.Size(1434, 299);
            this.dgListagemLivro.TabIndex = 0;
            this.dgListagemLivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListagemLivro_CellClick);
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
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 200;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 200;
            // 
            // DataLancamento
            // 
            this.DataLancamento.DataPropertyName = "DataLancamento";
            this.DataLancamento.HeaderText = "Lançamento";
            this.DataLancamento.MinimumWidth = 6;
            this.DataLancamento.Name = "DataLancamento";
            this.DataLancamento.ReadOnly = true;
            this.DataLancamento.Width = 200;
            // 
            // numeroPaginas
            // 
            this.numeroPaginas.DataPropertyName = "NumeroPaginas";
            this.numeroPaginas.HeaderText = "Páginas";
            this.numeroPaginas.MinimumWidth = 6;
            this.numeroPaginas.Name = "numeroPaginas";
            this.numeroPaginas.ReadOnly = true;
            this.numeroPaginas.Width = 80;
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
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Location = new System.Drawing.Point(12, 310);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(145, 62);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "apagar.png");
            this.imageList.Images.SetKeyName(1, "editar.png");
            // 
            // frmListagemLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 384);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgListagemLivro);
            this.Name = "frmListagemLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Listagem de Livros ::..";
            ((System.ComponentModel.ISupportInitialize)(this.dgListagemLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListagemLivro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPaginas;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
        private System.Windows.Forms.ImageList imageList;
    }
}