using AppInvest.Domain.Models;


namespace AppInvest.Domain.Interfaces.Repositories;

public interface IAcoesRepository : IBaseRepository<Acoes>
{
    Task<Acoes> BuscarAcoesId(int Id);
    Task<IEnumerable<Acoes>> BuscarAcoesNome(string nome);
    Task CadastrarAcoes(Acoes acoes);
    Task AtualizarAcoes(Acoes acoes);
    Task<IEnumerable<Acoes>> BuscarAcoes();
    Task DeletarAcoes(Acoes acoes);
}
