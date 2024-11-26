using AppInvest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Domain.Interfaces.Repositories
{
    public interface IAcoesRepository : IBaseRepository<Acoes>
    {
        Task<Acoes> BuscarAcoesId(int Id);
        Task CadastrarAcoes(Acoes acoes);
        Task AtualizarAcoes(Acoes acoes);
        Task<IEnumerable<Acoes>> BuscarAcoes();
        Task DeletarAcoes(Acoes acoes);
    }
}
