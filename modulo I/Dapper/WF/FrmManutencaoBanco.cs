using DLL;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmManutencaoBanco : Form
    {
        public BancoRepository BancoRepository { get; set; }

        public Banco Banco { get; set; }

        public FrmManutencaoBanco(int id)
        {
            InitializeComponent();

            BancoRepository = new BancoRepository();
            
            Obter(id);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Necessário informar o código", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Necessário informar o nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Obter(int id)
        {
            Banco = BancoRepository.Obter(id);

            if (Banco == null) //Novo
            {
                Banco = new Banco();
            }
            else //Editar
            {
                lblId.Text = Banco.Id.ToString();
                txtCodigo.Text = Banco.Codigo;
                txtNome.Text = Banco.Nome;
            }
        }

        private void Salvar()
        {
            if (CadastroEhValido())
            {
                Banco.Codigo = txtCodigo.Text;
                Banco.Nome = txtNome.Text;

                if (Banco.Id == 0)
                {
                    BancoRepository.Inserir(Banco);
                    MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BancoRepository.Editar(Banco);
                    MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }
    }
}
