using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livros
{
    public class Livro
    {
        /// <summary>
        /// Contrutor 1
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="dataLancamento"></param>
        /// <param name="numeroPaginas"></param>
        public Livro(string titulo,
            DateTime dataLancamento, int numeroPaginas)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            DataLancamento = dataLancamento;
            NumeroPaginas = numeroPaginas;
        }

        public Livro(string titulo, string autor,
           DateTime dataLancamento, int numeroPaginas)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Autor = autor;
            DataLancamento = dataLancamento;
            NumeroPaginas = numeroPaginas;
        }

        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public int NumeroPaginas { get; private set; }

        /// <summary>
        /// Este metodos realizar
        /// </summary>
        /// <param name="nomeAutor">Este sera o nome do autor do livro</param>
        public void SetarAutor(string nomeAutor)
        {
            Autor = nomeAutor;
        }
    }
}
