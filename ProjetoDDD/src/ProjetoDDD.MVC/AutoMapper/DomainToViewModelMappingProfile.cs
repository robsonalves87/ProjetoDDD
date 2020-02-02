using AutoMapper;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<CategoriaDoProdutoViewModel, CategoriaDoProduto>();
        }
    }
}