using AppInvest.Domain.Models.Command;
using AppInvest.Domain.Models;


namespace AppInvest.Domain.Interfaces.Services
{
    public interface IAcoesService
    {
        Task<Acoes> BuscarAcoesId(int Id);
        Task<Acoes> CadastrarAcoes(Acoes acoes);
        Task<Acoes> AtualizarAcoes(AtualizarAcoesCommand command);
        Task<IEnumerable<Acoes>> BuscarAcoes();
        Task<bool> DeletarAcoes(int Id);
    }
}
