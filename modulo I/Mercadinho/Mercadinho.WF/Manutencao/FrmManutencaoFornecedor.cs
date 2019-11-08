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
    public partial class FrmManutencaoFornecedor : Form
    {
        public FornecedorRepositorio FornecedorRepositorio { get; private set; }
        public Fornecedor Fornecedor { get; private set; }

        public FrmManutencaoFornecedor(FornecedorRepositorio fornecedorRepositorio, int id = 0)
        {
            InitializeComponent();

            FornecedorRepositorio = fornecedorRepositorio;

            Fornecedor = new Fornecedor();

            if (id > 0)
            {
                Fornecedor = FornecedorRepositorio.Obter(id);

                lblId.Text = Fornecedor.Id.ToString();
                txtCodigo.Text = Fornecedor.Codigo;
                txtNome.Text = Fornecedor.Nome;
                chbAtivo.Checked = Fornecedor.Ativo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CadastroEhValido())
            {
                Fornecedor.Codigo = txtCodigo.Text;
                Fornecedor.Nome = txtNome.Text;
                Fornecedor.Ativo = chbAtivo.Checked;

                if (Fornecedor.Id == 0)
                {
                    FornecedorRepositorio.Inserir(Fornecedor);
                    MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FornecedorRepositorio.Editar(Fornecedor);
                    MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Necessário informar o código!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Necessário informar o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
