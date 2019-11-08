using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmVenda : Form
    {
        public ClienteRepositorio ClienteRepositorio { get; private set; }
        public EstoqueRepositorio EstoqueRepositorio { get; private set; }
        public ProdutoRepositorio ProdutoRepositorio { get; private set; }
        public FornecedorRepositorio FornecedorRepositorio { get; private set; }
        public FrmVenda()
        {
            InitializeComponent();

            ClienteRepositorio = new ClienteRepositorio();
            EstoqueRepositorio = new EstoqueRepositorio();
            ProdutoRepositorio = new ProdutoRepositorio();
            FornecedorRepositorio = new FornecedorRepositorio();

            CarregarClientes();

            CarregarProdutos();
        }

        private void CarregarClientes()
        {
            cmbClientes.DataSource = ClienteRepositorio.ObterTodos(); ;
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Id";

            cmbClientes.SelectedValue = -1;
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
            int produtoId = Convert.ToInt32(cmbProdutos.SelectedValue);
            int quantidade = Convert.ToInt32(txtQtde.Value);

            EstoqueRepositorio.EfetuarVenda(produtoId, quantidade);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int produtoId = Convert.ToInt32(cmbProdutos.SelectedValue);

            Produto produto = ProdutoRepositorio.Obter(produtoId);

            decimal valorProduto = (produto.ValorVenda * txtQtde.Value);
            txtValorTotalProdutos.Text = (valorProduto == 0 ? 1 : valorProduto).ToString();

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);
            Cliente cliente = ClienteRepositorio.Obter(clienteId);

            if (cliente != null)
            {
                if (cliente.DataNascimento == DateTime.Now)
                    txtValorDesconto.Text = "10";
            }

            txtValorTotalVenda.Text = (Convert.ToDecimal(txtValorTotalProdutos.Text) + Convert.ToDecimal(txtValorDesconto.Text)).ToString();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorDesconto.Text = "0";
            txtValorTotalProdutos.Text = "0";
            txtValorTotalVenda.Text = "0";
        }
    }
}
