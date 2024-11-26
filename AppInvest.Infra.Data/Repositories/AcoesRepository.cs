using AppInvest.Domain.Interfaces.Repositories;
using AppInvest.Domain.Models;
using AppInvest.Infra.Data.EF;
using AppInvest.Infra.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AppInvest.Infra.Data.Repositories
{
    public class AcoesRepository : BaseRepository<Acoes>, IAcoesRepository
    {
        private readonly CadastroContext _context;

        public AcoesRepository(CadastroContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Acoes>> BuscarAcoes()
        {
            return await _context.Acoes.ToListAsync();
        }

        public async Task<Acoes> BuscarAcoesId(int Id)
        {
            return _context.Acoes.Find(Id);
        }

        public async Task<Acoes> AcoesAcoesId(long id)
        {
            return await _context.Acoes.FindAsync(id);
        }

        public async Task CadastrarAcoes(Acoes acoes)
        {
            await _context.AddAsync(acoes);
        }

        public async Task AtualizarAcoes(Acoes acoes)
        {
            await Task.FromResult(_context.Update(acoes));
        }

        public async Task DeletarAcoes(Acoes acoes)
        {
            await Task.FromResult(_context.Remove(acoes));
        }

        public Task AtualizacaoParcial(Acoes acoesParcial)
        {
            throw new NotImplementedException();
        }

    }
}
