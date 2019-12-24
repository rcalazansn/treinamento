using AutoMapper;
using RCN.Api.ViewModel;
using RCN.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCN.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorAdicionarViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorEditarViewModel>().ReverseMap();

            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoAdicionarViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoEditarViewModel>().ReverseMap();

        }
    }
}
