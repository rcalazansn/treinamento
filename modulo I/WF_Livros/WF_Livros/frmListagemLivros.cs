using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Livros
{
    public partial class frmListagemLivros : Form
    {
        public List<Livro> Livros { get; set; }
        public frmListagemLivros()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Livros = new List<Livro>();

            Livros.Add(new Livro("Titulo 1", "Autor 1", DateTime.Now.AddDays(-50), 10));
            Livros.Add(new Livro("Titulo 2", "Autor 2", DateTime.Now.AddMonths(-5), 20));
            Livros.Add(new Livro("Titulo 3", "Autor 3", DateTime.Now.AddMonths(-12), 30));

            dgListagemLivro.AutoGenerateColumns = false;
            dgListagemLivro.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListagemLivro.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            AtualizarGrid();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmManutencaoLivro frm = new frmManutencaoLivro();
            frm.ShowDialog();

            Livros.Add(frm.LivroManutencao);

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgListagemLivro.DataSource = null;
            dgListagemLivro.DataSource = Livros
                .OrderBy(item => item.DataLancamento)
                .ToList();
        }

        private void DgListagemLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                Livro itemSelecionado = (Livro)dgListagemLivro.Rows[e.RowIndex].DataBoundItem;

                if (dgListagemLivro.Columns[e.ColumnIndex].Name == "btnEditar") //Editar
                {
                    frmManutencaoLivro frm = new frmManutencaoLivro();
                    frm.PreecherLivro(itemSelecionado);
                    frm.ShowDialog();

                    Livros.Remove(itemSelecionado);
                    Livros.Add(frm.LivroManutencao);

                    AtualizarGrid();
                }

                if (e.ColumnIndex == 6) //Apagar
                {
                    DialogResult resut = MessageBox.Show("Deseja apagar o item?", "Remover",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resut == DialogResult.Yes)
                    {
                        Livros.Remove(itemSelecionado);

                        AtualizarGrid();
                    }
                }
            }
        }
    }
}
