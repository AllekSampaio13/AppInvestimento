using AppInvest.Domain.Interfaces.Repositories;
using AppInvest.Domain.Models;
using AppInvest.Infra.Data.EF;
using AppInvest.Infra.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;


namespace AppInvest.Infra.Data.Repositories;

public class UsuariosRepository : BaseRepository<UsuariosInvest>, IUsuariosRepository
{
    private readonly CadastroContext _context;

    public UsuariosRepository(CadastroContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UsuariosInvest>> BuscarUsuarios()
    {
        return await _context.UsuariosInvest.ToListAsync();
    }

    public async Task<IEnumerable<UsuariosInvest>> BuscarUsuariosNome(string nome)
    {
        var result = await _context.UsuariosInvest.Where(x => x.Nome.Contains(nome)).ToListAsync();
        return result;
    }

    public async Task<UsuariosInvest> UsuariosUsuariosId(long id)
    {
        return await _context.UsuariosInvest.FindAsync(id);
    }

    public async Task CadastrarUsuarios(UsuariosInvest usuarios)
    {
        await _context.AddAsync(usuarios);
    }

    public async Task AtualizarUsuarios(UsuariosInvest usuarios)
    {
        await Task.FromResult(_context.Update(usuarios));
    }

    public async Task DeletarUsuarios(UsuariosInvest usuarios)
    {
        await Task.FromResult(_context.Remove(usuarios));
    }

    public Task AtualizacaoParcial(UsuariosInvest usuariosParcial)
    {
        throw new NotImplementedException();
    }



}
