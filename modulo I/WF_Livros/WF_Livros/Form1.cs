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
    public partial class frmManutencaoLivro : Form
    {
         public Livro LivroManutencao { get; private set; }

        public frmManutencaoLivro()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LivroManutencao = new Livro(
                txtTitulo.Text,
                txtDataLancamento.Value,
                Convert.ToInt32(txtNumeroPaginas.Value)
                );


            Close();
        }        

        public void PreecherLivro(Livro livro)
        {
            txtId.Text = livro.Id.ToString();
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            txtDataLancamento.Value = livro.DataLancamento;
            txtNumeroPaginas.Value = livro.NumeroPaginas;
        }
    }
}
