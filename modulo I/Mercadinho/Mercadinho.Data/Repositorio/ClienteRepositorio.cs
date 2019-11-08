using Mercadinho.Data.Modelo;
using Mercadinho.Data.Repositorio.Interfaces;
using System;

namespace Mercadinho.Data.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public void AtualizarDataUltimaCompra(int id)
        {
            var cliente = Obter(id);

            cliente.DataUltimaCompra = DateTime.Now;

            Editar(cliente);
        }
    }
}
