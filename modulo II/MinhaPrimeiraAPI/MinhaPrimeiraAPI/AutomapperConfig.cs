using AutoMapper;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.ViewModels;

namespace MinhaPrimeiraAPI
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {

            CreateMap<Produto, ProdutoAdicionarViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoEditarViewModel>().ReverseMap();
        }
    }
}
