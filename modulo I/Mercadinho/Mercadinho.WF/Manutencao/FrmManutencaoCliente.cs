using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmManutencaoCliente : Form
    {
        public ClienteRepositorio ClienteRepositorio { get; private set; }
        public Cliente Cliente { get; private set; }
        public FrmManutencaoCliente(ClienteRepositorio clienteRepositorio, int id = 0)
        {
            InitializeComponent();

            ClienteRepositorio = clienteRepositorio;

            Cliente = new Cliente();

            if (id > 0)
            {
                Cliente = ClienteRepositorio.Obter(id);

                lblId.Text = Cliente.Id.ToString();
                txtNome.Text = Cliente.Nome;
                txtNascimento.Value = Cliente.DataNascimento;
            }
        }
        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (CadastroEhValido())
            {
                Cliente.Nome = txtNome.Text;
                Cliente.DataNascimento = txtNascimento.Value;

                if (Cliente.Id == 0)
                {
                    ClienteRepositorio.Inserir(Cliente);
                    MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    ClienteRepositorio.Editar(Cliente);
                    MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close(); 
            }
        }
        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Necessário informar o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
