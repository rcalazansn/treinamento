using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmManutencaoProduto : Form
    {
        public ProdutoRepositorio ProdutoRepositorio { get; private set; }
        public Produto Produto { get; private set; }
        public FrmManutencaoProduto(ProdutoRepositorio produtoRepositorio, int id = 0)
        {
            InitializeComponent();

            ProdutoRepositorio = produtoRepositorio;

            Produto = new Produto();

            if (id > 0)
            {
                Produto = ProdutoRepositorio.Obter(id);

                lblId.Text = Produto.Id.ToString();
                txtCodigo.Text = Produto.Codigo;
                txtDescricao.Text = Produto.Descricao;
                txtCompra.Text = Produto.ValorVenda.ToString();
                txtLucro.Text = Produto.Lucro.ToString();
                txtVenda.Text = Produto.ValorVenda.ToString();
                chbAtivo.Checked = Produto.Ativo;
            }
        }

        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Necessário informar o código!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Necessário informar a descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtCompra.Text))
            {
                MessageBox.Show("Necessário informar o valor de compra!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtLucro.Text))
            {
                MessageBox.Show("Necessário informar o lucro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CadastroEhValido())
            {
                Produto.Codigo = txtCodigo.Text;
                Produto.Descricao = txtDescricao.Text;
                Produto.Ativo = chbAtivo.Checked;
                Produto.ValorCompra = Convert.ToDecimal(txtCompra.Text);
                Produto.Lucro = Convert.ToInt32(txtLucro.Text);
                Produto.ValorVenda = Convert.ToDecimal(txtVenda.Text);

                if (Produto.Id == 0)
                {
                    ProdutoRepositorio.Inserir(Produto);
                    MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ProdutoRepositorio.Editar(Produto);
                    MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private void CalcularValorVenda()
        {
            decimal compra = 0;
            int lucro = 0;

            if (!string.IsNullOrEmpty(txtCompra.Text))
                compra = Convert.ToDecimal(txtCompra.Text);

            if (!string.IsNullOrEmpty(txtLucro.Text))
                lucro = Convert.ToInt32(txtLucro.Text);

            txtVenda.Text = (((compra * lucro) / 100) + compra).ToString();
        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {
            CalcularValorVenda();
        }

        private void txtCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularValorVenda();
        }
    }
}
