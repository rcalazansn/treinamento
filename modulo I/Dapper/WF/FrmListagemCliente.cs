using DLL;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmListagemCliente : Form
    {
        public ClienteRepository ClienteRepository { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }
        public FrmListagemCliente()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            ClienteRepository = new ClienteRepository();

            Clientes = new List<Cliente>();

            gridClientes.AutoGenerateColumns = false;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            Clientes = ClienteRepository.Obter();

            gridClientes.DataSource = null;
            gridClientes.DataSource = Clientes
                //.OrderBy(item => item.DataLancamento)
                .ToList();
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                Cliente itemSelecionado = (Cliente)gridClientes.Rows[e.RowIndex].DataBoundItem;

                if (gridClientes.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    FrmManutencaoCliente frm = new FrmManutencaoCliente(itemSelecionado.Id);
                    frm.ShowDialog();

                    AtualizarGrid();
                }

                if (gridClientes.Columns[e.ColumnIndex].Name == "btnApagar") //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        ClienteRepository.Apagar(itemSelecionado.Id);

                        AtualizarGrid();
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            FrmManutencaoCliente frm = new FrmManutencaoCliente(0);
            frm.ShowDialog();

            AtualizarGrid();
        }
    }
}
