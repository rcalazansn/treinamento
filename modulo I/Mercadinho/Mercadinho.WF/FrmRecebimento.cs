using Mercadinho.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmRecebimento : Form
    {
        public FornecedorRepositorio FornecedorRepositorio { get; private set; }
        public ProdutoRepositorio ProdutoRepositorio { get; private set; }
        public EstoqueRepositorio EstoqueRepositorio { get; private set; }
        
        public FrmRecebimento()
        {
            InitializeComponent();

            FornecedorRepositorio = new FornecedorRepositorio();
            ProdutoRepositorio = new ProdutoRepositorio();
            EstoqueRepositorio = new EstoqueRepositorio();

            CarregarFornecedores();
            CarregarProdutos();
        }

        private void CarregarFornecedores()
        {
            cmbFornecedores.DataSource = FornecedorRepositorio.ObterAtivos();
            cmbFornecedores.DisplayMember = "Nome";
            cmbFornecedores.ValueMember = "Id";

            cmbFornecedores.SelectedValue = -1;
        }

        private void CarregarProdutos()
        {
            cmbProdutos.DataSource = ProdutoRepositorio.ObterAtivos();
            cmbProdutos.DisplayMember = "Descricao";
            cmbProdutos.ValueMember = "Id";

            cmbProdutos.SelectedValue = -1;
        }

        private void btnEfetivar_Click(object sender, EventArgs e)
        {
            int fornecedorId = Convert.ToInt32(cmbFornecedores.SelectedValue);

            int produtoId = Convert.ToInt32(cmbProdutos.SelectedValue);
            int quantidade = Convert.ToInt32(txtQtde.Value);

            EstoqueRepositorio.EfetuarRecevimento(produtoId, quantidade);
            FornecedorRepositorio.EfetuarRecevimento(fornecedorId, quantidade);
        }
    }
}
