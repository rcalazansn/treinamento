using RCN.Business.Interfaces;
using RCN.Business.Model;
using RCN.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCN.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApiContext apiContext) 
            : base(apiContext)
        {

        }
    }
}
