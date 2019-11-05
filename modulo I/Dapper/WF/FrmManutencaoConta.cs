using DLL;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmManutencaoConta : Form
    {
        public ContaRepository ContaRepository { get; set; }
        public ClienteRepository ClienteRepository { get; set; }
        public BancoRepository BancoRepository { get; set; }

        public Conta Conta { get; set; }
        public FrmManutencaoConta(int id)
        {
            InitializeComponent();

            ContaRepository = new ContaRepository();
            BancoRepository = new BancoRepository();
            ClienteRepository = new ClienteRepository();

            PreencherComboCliente();

            PreencherComboBanco();

            Obter(id);
        }

        private void Obter(int id)
        {
            Conta = ContaRepository.Obter(id);

            if (Conta == null) //Novo
            {
                Conta = new Conta();
            }
            else //Editar
            {
                lblId.Text = Conta.Id.ToString();
                txtAgencia.Text = Conta.Agencia;
                txtContaCorrente.Text = Conta.ContaCorrente;
                txtLimite.Text = Conta.Limite.ToString();
                txtSaldo.Text = Conta.Saldo.ToString();

                cmbCliente.SelectedValue = Conta.ClienteId;
                cmbCliente.Refresh();

                cmbBanco.SelectedValue = Conta.BancoId;
                cmbBanco.Refresh();
            }
        }

        private void Salvar()
        {
            if (CadastroEhValido())
            {
                Conta.Agencia = txtAgencia.Text;
                Conta.ContaCorrente = txtContaCorrente.Text;
                Conta.Limite = Convert.ToDecimal(txtLimite.Text);
                Conta.Saldo = Convert.ToDecimal(txtSaldo.Text);

                // var idCliente =  cmbCliente.SelectedValue;
                //  var objetoCliente = (Cliente)cmbCliente.SelectedItem;
                var idCliente = ((Cliente)cmbCliente.SelectedItem).Id;

                var idBanco = ((Banco)cmbBanco.SelectedItem).Id;

                Conta.ClienteId = idCliente;
                Conta.BancoId = idBanco;

                if (Conta.Id == 0)
                {
                    ContaRepository.Inserir(Conta);
                    MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ContaRepository.Editar(Conta);
                    MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }
        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txtAgencia.Text))
            {
                MessageBox.Show("Necessário informar a agencia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtContaCorrente.Text))
            {
                MessageBox.Show("Necessário informar a conta corrente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtLimite.Text))
            {
                MessageBox.Show("Necessário informar o limite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtSaldo.Text))
            {
                MessageBox.Show("Necessário informar o saldo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void PreencherComboCliente()
        {
            cmbCliente.DisplayMember = "NomeTitular";
            cmbCliente.ValueMember = "Id";

            cmbCliente.DataSource = ClienteRepository.Obter();

            cmbCliente.SelectedValue = -1;
        }

        private void PreencherComboBanco()
        {
            cmbBanco.DisplayMember = "Nome";
            cmbBanco.ValueMember = "Id";

            cmbBanco.DataSource = BancoRepository.Obter();

            cmbBanco.SelectedValue = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
