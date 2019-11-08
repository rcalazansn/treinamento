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
    public partial class FrmListagemProdutos : Form
    {
        public ProdutoRepositorio ProdutoRepositorio { get; set; }
        public FrmListagemProdutos()
        {
            InitializeComponent();

            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmManutencaoProduto frm = new FrmManutencaoProduto(ProdutoRepositorio);
            frm.ShowDialog();

            AtualizarGrid();
        }

        private void Initialize()
        {
            ProdutoRepositorio = new ProdutoRepositorio();

            gridProdutos.AutoGenerateColumns = false;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = ProdutoRepositorio.ObterTodos();
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                Produto itemSelecionado = (Produto)gridProdutos.Rows[e.RowIndex].DataBoundItem;

                if (gridProdutos.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    FrmManutencaoProduto frm = new FrmManutencaoProduto(ProdutoRepositorio,itemSelecionado.Id);
                    frm.ShowDialog();

                    AtualizarGrid();
                }

                if (gridProdutos.Columns[e.ColumnIndex].Name == "btnApagar") //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        ProdutoRepositorio.Apagar(itemSelecionado);

                        AtualizarGrid();
                    }
                }
            }
        }
    }
}
