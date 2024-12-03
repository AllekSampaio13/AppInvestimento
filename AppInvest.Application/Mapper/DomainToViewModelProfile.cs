using AppInvest.Application.ViewModel;
using AppInvest.Domain.Models;
using AutoMapper;


namespace AppInvest.Application.Mapper
{
    public class DomainToViewModelProfile : Profile
    {

        public DomainToViewModelProfile()
        {
            CreateMap<Acoes, AcoesViewModel>();
        }

    }
}
