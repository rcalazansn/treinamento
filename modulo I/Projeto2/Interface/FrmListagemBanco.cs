using Projeto2;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmListagemBanco : Form
    {
        public BancoRepository BancoRepository { get; set; }
        public IEnumerable<Banco> Bancos { get; set; }

        public FrmListagemBanco()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            BancoRepository = new BancoRepository();

            Bancos = new List<Banco>();

            gridBancos.AutoGenerateColumns = false;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            Bancos = BancoRepository.Obter();

            gridBancos.DataSource = null;
            gridBancos.DataSource = Bancos.ToList();
        }

        private void gridBancos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                Banco itemSelecionado = (Banco)gridBancos.Rows[e.RowIndex].DataBoundItem;

                if (gridBancos.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    FrmManutencaoBanco frm = new FrmManutencaoBanco(itemSelecionado.Id);
                    frm.ShowDialog();

                    AtualizarGrid();
                }

                if (gridBancos.Columns[e.ColumnIndex].Name == "btnApagar") //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        BancoRepository.Apagar(itemSelecionado.Id);

                        AtualizarGrid();
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            FrmManutencaoBanco frm = new FrmManutencaoBanco(0);
            frm.ShowDialog();

            AtualizarGrid();
        }
    }
}
