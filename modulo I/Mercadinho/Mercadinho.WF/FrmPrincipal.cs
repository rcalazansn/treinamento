using System;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListagemClientes frm = new FrmListagemClientes();
            frm.ShowDialog();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FrmListagemFornecedores frm = new FrmListagemFornecedores();
            frm.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmListagemProdutos frm = new FrmListagemProdutos();
            frm.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FrmVenda frm = new FrmVenda();
            frm.ShowDialog();
        }

        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            FrmRecebimento frm = new FrmRecebimento();
            frm.ShowDialog();
        }
    }
}
