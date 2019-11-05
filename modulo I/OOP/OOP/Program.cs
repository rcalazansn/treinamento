namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            CrudPessoaJuridica _crudPJ = new CrudPessoaJuridica();
            _crudPJ.Inserir(new PessoaJuridica());


            CrudPessoaFisica _crudPF = new CrudPessoaFisica();
            _crudPF.Editar(new PessoaFisica());
        }
    }
}
