using Projeto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmListagemConta : Form
    {
        public ContaRepository ContaRepository { get; set; }
        public IEnumerable<Conta> Contas { get; set; }
        public FrmListagemConta()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            ContaRepository = new ContaRepository();

            Contas = new List<Conta>();

            gridContas.AutoGenerateColumns = false;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            Contas = ContaRepository.Obter();

            gridContas.DataSource = null;
            gridContas.DataSource = Contas.ToList();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmManutencaoConta frm = new FrmManutencaoConta(0);
            frm.ShowDialog();
        }

        private void gridContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                Conta itemSelecionado = (Conta)gridContas.Rows[e.RowIndex].DataBoundItem;

                if (gridContas.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    FrmManutencaoConta frm = new FrmManutencaoConta(itemSelecionado.Id);
                    frm.ShowDialog();

                    AtualizarGrid();
                }

                if (gridContas.Columns[e.ColumnIndex].Name == "btnApagar") //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        ContaRepository.Apagar(itemSelecionado.Id);

                        AtualizarGrid();
                    }
                }
            }
        }
    }
}
