

using AppInvest.Application.ViewModel;

namespace AppInvest.Application.Services.Interfaces
{
    public interface IAcoesAppService
    {
        Task<AcoesViewModel> CadastrarAcoes(NovoAcoesViewModel novoAcoesViewModel);
        Task<AcoesViewModel> AtualizarAcoes(AtualizarAcoesViewModel atualizarAcoesViewModel);
        Task<IEnumerable<AcoesViewModel>> BuscarAcoes();
        Task<AcoesViewModel> BuscarAcoesId(int Id);
        Task<bool> DeletarAcoes(int Id);
    }
}
