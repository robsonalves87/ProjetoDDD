using AutoMapper;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<CategoriaDoProduto, CategoriaDoProdutoViewModel>();
        }
    }
}