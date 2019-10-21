using Projeto2;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmManutencaoCliente : Form
    {
        public ClienteRepository ClienteRepository { get; set; }

        public Cliente Cliente { get; set; }
        public FrmManutencaoCliente(int id)
        {
            InitializeComponent();

            ClienteRepository = new ClienteRepository();

            Obter(id);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txtNomeTitular.Text))
            {
                MessageBox.Show("Necessário informar o nome do titular!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Obter(int id)
        {
            Cliente = ClienteRepository.Obter(id);

            if (Cliente == null) //Novo
            {
                Cliente = new Cliente();
            }
            else //Editar
            {
                lblId.Text = Cliente.Id.ToString();
                txtNomeTitular.Text = Cliente.NomeTitular;
                txtNascimento.Value = Cliente.Nascimento;
            }
        }

        private void Salvar()
        {
            if (CadastroEhValido())
            {
                Cliente.NomeTitular = txtNomeTitular.Text;
                Cliente.Nascimento = txtNascimento.Value;

                if (Cliente.Id == 0)
                {
                    ClienteRepository.Inserir(Cliente);
                    MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ClienteRepository.Editar(Cliente);
                    MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }
    }
}
