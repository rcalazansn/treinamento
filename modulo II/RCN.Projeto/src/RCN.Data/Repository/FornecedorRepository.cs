using RCN.Business.Interfaces;
using RCN.Business.Model;
using RCN.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCN.Data.Repository
{
    public class FornecedorRepository: Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ApiContext apiContext) 
            : base(apiContext)
        {

        }
    }
}
