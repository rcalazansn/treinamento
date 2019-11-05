using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPrincipal : Form
    {
        #region Contrutores
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void MenuListagemClientes_Click(object sender, EventArgs e)
        {
            FrmListagemCliente frm = new FrmListagemCliente();

            AbrirForm(frm);
        }

        private void MenuListagemContas_Click(object sender, EventArgs e)
        {
            FrmListagemConta frm = new FrmListagemConta();

            AbrirForm(frm);
        }

        private void MenuListagemBanco_Click(object sender, EventArgs e)
        {
            FrmListagemBanco frm = new FrmListagemBanco();

            AbrirForm(frm);
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuNovoBanco_Click(object sender, EventArgs e)
        {
            FrmManutencaoBanco frm = new FrmManutencaoBanco(0);

            AbrirForm(frm);
        }

        private void MenuNovoCliente_Click(object sender, EventArgs e)
        {
            FrmManutencaoCliente frm = new FrmManutencaoCliente(0);

            AbrirForm(frm);
        }

        private void MenuNovaConta_Click(object sender, EventArgs e)
        {
            FrmManutencaoConta frm = new FrmManutencaoConta(0);

            AbrirForm(frm);
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            FrmListagemBanco frm = new FrmListagemBanco();

            AbrirForm(frm);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListagemCliente frm = new FrmListagemCliente();

            AbrirForm(frm);
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            FrmListagemConta frm = new FrmListagemConta();

            AbrirForm(frm);
        }

        private void btnCaixaEletronico_Click(object sender, EventArgs e)
        {
            FrmCaixaEletronico frm = new FrmCaixaEletronico();

            AbrirForm(frm);
        }
        #endregion

        #region Metodos
        private void AbrirForm(Form form)
        {
            Hide();
            
            form.ShowDialog();

            Show();
        }
        #endregion
    }
}
