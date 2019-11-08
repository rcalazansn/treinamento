using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio;
using System;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmListagemFornecedores : Form
    {
        public FornecedorRepositorio FornecedorRepositorio { get; set; }
        public FrmListagemFornecedores()
        {
            InitializeComponent();

            Initialize();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmManutencaoFornecedor frm = new FrmManutencaoFornecedor(FornecedorRepositorio);
            frm.ShowDialog();

            AtualizarGrid();
        }
        private void Initialize()
        {
            FornecedorRepositorio = new FornecedorRepositorio();

            gridFornecedores.AutoGenerateColumns = false;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            gridFornecedores.DataSource = null;
            gridFornecedores.DataSource = FornecedorRepositorio.ObterTodos();
        }

        private void gridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                Fornecedor itemSelecionado = (Fornecedor)gridFornecedores.Rows[e.RowIndex].DataBoundItem;

                if (gridFornecedores.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    FrmManutencaoFornecedor frm = new FrmManutencaoFornecedor(FornecedorRepositorio,itemSelecionado.Id);
                    frm.ShowDialog();

                    AtualizarGrid();
                }

                if (gridFornecedores.Columns[e.ColumnIndex].Name == "btnApagar") //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        FornecedorRepositorio.Apagar(itemSelecionado);

                        AtualizarGrid();
                    }
                }
            }
        }
    }
}
