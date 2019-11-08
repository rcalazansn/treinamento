using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mercadinho.WF
{
    public partial class FrmListagemClientes : Form
    {
        public ClienteRepositorio ClienteRepositorio { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }
        public FrmListagemClientes()
        {
            InitializeComponent();
            
            Initialize();
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                Cliente itemSelecionado = (Cliente)gridClientes.Rows[e.RowIndex].DataBoundItem;

                if (gridClientes.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    FrmManutencaoCliente frm = new FrmManutencaoCliente(ClienteRepositorio, itemSelecionado.Id);
                    frm.ShowDialog();

                    AtualizarGrid();
                }

                if (gridClientes.Columns[e.ColumnIndex].Name == "btnApagar") //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        ClienteRepositorio.Apagar(itemSelecionado);

                        AtualizarGrid();
                    }
                }
            }
        }

        private void Initialize()
        {
            ClienteRepositorio = new ClienteRepositorio();

            Clientes = new List<Cliente>();

            gridClientes.AutoGenerateColumns = false;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            Clientes = ClienteRepositorio.ObterTodos();

            gridClientes.DataSource = null;
            gridClientes.DataSource = Clientes.ToList();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmManutencaoCliente frm = new FrmManutencaoCliente(ClienteRepositorio);
            frm.ShowDialog();

            AtualizarGrid();
        }
    }
}
