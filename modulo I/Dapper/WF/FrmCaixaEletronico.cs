using DLL;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmCaixaEletronico : Form
    {
        public ContaRepository ContaRepository { get; set; }
        public FrmCaixaEletronico()
        {
            InitializeComponent();

            ContaRepository = new ContaRepository();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            Conta contaCorrente = ObterConta(txtAgenciaOrigem.Text, txtContaCorrenteOrigem.Text);

            if (contaCorrente != null)
            {
                if (ValorValido())
                {
                    decimal valor = Convert.ToDecimal(txtValor.Text);

                    if (ContaRepository.ExisteSaldo(contaCorrente.Id, valor))
                    {
                        ContaRepository.RealizarSaque(contaCorrente, valor);
                        MessageBox.Show("Operação efetuada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não existe saldo para efetuar a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Conta contaCorrente = ObterConta(txtAgenciaOrigem.Text, txtContaCorrenteOrigem.Text);

            if (contaCorrente != null)
            {

                if (ValorValido())
                {
                    decimal valor = Convert.ToDecimal(txtValor.Text);

                    ContaRepository.RealizarDeposito(contaCorrente, valor);
                    MessageBox.Show("Operação efetuada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Conta contaCorrenteOrigem = ObterConta(txtAgenciaOrigem.Text, txtContaCorrenteOrigem.Text);
            Conta contaCorrenteDestino = ObterConta(txtAgenciaDestino.Text, txtContaCorrenteDestino.Text);

            if (contaCorrenteOrigem != null && contaCorrenteDestino != null)
            {
                if (ValorValido())
                {
                    decimal taxa = 0;
                    if (contaCorrenteOrigem.BancoId != contaCorrenteDestino.BancoId)
                    {
                        taxa = 3.50M;
                    }

                    decimal valor = Convert.ToDecimal(txtValor.Text) + taxa;

                    if (ContaRepository.ExisteSaldo(contaCorrenteOrigem.Id, valor))
                    {
                        ContaRepository.RealizarTransferecia(contaCorrenteOrigem, contaCorrenteDestino, valor);

                        MessageBox.Show("Operação efetuada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não existe saldo para efetuar a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool ValorValido()
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Necessário informar o valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (Convert.ToDecimal(txtValor.Text) <= 0)
            {
                MessageBox.Show("Deve ser informado um valor maior que zero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private bool ContaCorrenteValida()
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Conta Corrente não pree informar o valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private Conta ObterConta(string agencia, string conta)
        {
            if (string.IsNullOrEmpty(agencia))
            {
                MessageBox.Show("Agencia não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (string.IsNullOrEmpty(conta))
            {
                MessageBox.Show("Conta corrente não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            Conta contaCorrente = ContaRepository.Obter(agencia, conta);

            if (contaCorrente == null)
            {
                MessageBox.Show("Agencia/Conta corrente não foi encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return contaCorrente;
        }
    }
}
