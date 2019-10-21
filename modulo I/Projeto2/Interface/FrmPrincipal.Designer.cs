namespace Interface
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuListagemBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuListagemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuListagemContas = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovoBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuNovoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuNovaConta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnBancos = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.btnCaixaEletronico = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.MenuSair});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(437, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListagemBanco,
            this.toolStripMenuItem2,
            this.MenuListagemClientes,
            this.toolStripMenuItem1,
            this.MenuListagemContas});
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.listagemToolStripMenuItem.Text = "&Listagem";
            // 
            // MenuListagemBanco
            // 
            this.MenuListagemBanco.Name = "MenuListagemBanco";
            this.MenuListagemBanco.Size = new System.Drawing.Size(224, 26);
            this.MenuListagemBanco.Text = "&Bancos";
            this.MenuListagemBanco.Click += new System.EventHandler(this.MenuListagemBanco_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuListagemClientes
            // 
            this.MenuListagemClientes.Name = "MenuListagemClientes";
            this.MenuListagemClientes.Size = new System.Drawing.Size(224, 26);
            this.MenuListagemClientes.Text = "&Clientes";
            this.MenuListagemClientes.Click += new System.EventHandler(this.MenuListagemClientes_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuListagemContas
            // 
            this.MenuListagemContas.Name = "MenuListagemContas";
            this.MenuListagemContas.Size = new System.Drawing.Size(224, 26);
            this.MenuListagemContas.Text = "C&ontas";
            this.MenuListagemContas.Click += new System.EventHandler(this.MenuListagemContas_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovoBanco,
            this.toolStripMenuItem3,
            this.MenuNovoCliente,
            this.toolStripMenuItem4,
            this.MenuNovaConta});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // MenuNovoBanco
            // 
            this.MenuNovoBanco.Name = "MenuNovoBanco";
            this.MenuNovoBanco.Size = new System.Drawing.Size(224, 26);
            this.MenuNovoBanco.Text = "&Banco";
            this.MenuNovoBanco.Click += new System.EventHandler(this.MenuNovoBanco_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuNovoCliente
            // 
            this.MenuNovoCliente.Name = "MenuNovoCliente";
            this.MenuNovoCliente.Size = new System.Drawing.Size(224, 26);
            this.MenuNovoCliente.Text = "&Cliente";
            this.MenuNovoCliente.Click += new System.EventHandler(this.MenuNovoCliente_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuNovaConta
            // 
            this.MenuNovaConta.Name = "MenuNovaConta";
            this.MenuNovaConta.Size = new System.Drawing.Size(224, 26);
            this.MenuNovaConta.Text = "C&onta";
            this.MenuNovaConta.Click += new System.EventHandler(this.MenuNovaConta_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(48, 24);
            this.MenuSair.Text = "&Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.ImageIndex = 1;
            this.btnClientes.ImageList = this.imageList;
            this.btnClientes.Location = new System.Drawing.Point(153, 49);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(120, 99);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnBancos
            // 
            this.btnBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBancos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBancos.ImageKey = "banco.png";
            this.btnBancos.ImageList = this.imageList;
            this.btnBancos.Location = new System.Drawing.Point(12, 49);
            this.btnBancos.Name = "btnBancos";
            this.btnBancos.Size = new System.Drawing.Size(119, 99);
            this.btnBancos.TabIndex = 2;
            this.btnBancos.Text = "Bancos";
            this.btnBancos.UseVisualStyleBackColor = true;
            this.btnBancos.Click += new System.EventHandler(this.btnBancos_Click);
            // 
            // btnContas
            // 
            this.btnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContas.ImageKey = "conta.png";
            this.btnContas.ImageList = this.imageList;
            this.btnContas.Location = new System.Drawing.Point(295, 49);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(119, 99);
            this.btnContas.TabIndex = 3;
            this.btnContas.Text = "Contas";
            this.btnContas.UseVisualStyleBackColor = true;
            this.btnContas.Click += new System.EventHandler(this.btnContas_Click);
            // 
            // btnCaixaEletronico
            // 
            this.btnCaixaEletronico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixaEletronico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixaEletronico.ImageKey = "banco.png";
            this.btnCaixaEletronico.ImageList = this.imageList;
            this.btnCaixaEletronico.Location = new System.Drawing.Point(12, 166);
            this.btnCaixaEletronico.Name = "btnCaixaEletronico";
            this.btnCaixaEletronico.Size = new System.Drawing.Size(404, 99);
            this.btnCaixaEletronico.TabIndex = 4;
            this.btnCaixaEletronico.Text = "Caixa Eletrônico";
            this.btnCaixaEletronico.UseVisualStyleBackColor = true;
            this.btnCaixaEletronico.Click += new System.EventHandler(this.btnCaixaEletronico_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "banco.png");
            this.imageList.Images.SetKeyName(1, "cliente.png");
            this.imageList.Images.SetKeyName(2, "conta.png");
            this.imageList.Images.SetKeyName(3, "deposito.png");
            this.imageList.Images.SetKeyName(4, "saque.png");
            this.imageList.Images.SetKeyName(5, "transferencia.png");
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 279);
            this.Controls.Add(this.btnCaixaEletronico);
            this.Controls.Add(this.btnContas);
            this.Controls.Add(this.btnBancos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Principal ::..";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuListagemBanco;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuListagemClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuListagemContas;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNovoBanco;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuNovoCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuNovaConta;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnBancos;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnCaixaEletronico;
        private System.Windows.Forms.ImageList imageList;
    }
}

