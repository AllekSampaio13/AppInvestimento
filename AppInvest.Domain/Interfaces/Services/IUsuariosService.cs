using AppInvest.Domain.Models.Command;
using AppInvest.Domain.Models;


namespace AppInvest.Domain.Interfaces.Services;

public interface IUsuariosService
{
    Task<IEnumerable<UsuariosInvest>> BuscarUsuariosNome(string nome);
    Task<UsuariosInvest> CadastrarUsuarios(UsuariosInvest usuarios);
    Task<UsuariosInvest> AtualizarUsuarios(AtualizarUsuariosCommand command);
    Task<IEnumerable<UsuariosInvest>> BuscarUsuarios();
    Task<bool> DeletarUsuarios(int Id);
}
