using AppInvest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Domain.Interfaces.Repositories;

public interface IUsuariosRepository : IBaseRepository<UsuariosInvest>
{
    Task<IEnumerable<UsuariosInvest>> BuscarUsuariosNome(string nome);
    Task CadastrarUsuarios(UsuariosInvest usuarios);
    Task AtualizarUsuarios(UsuariosInvest usuarios);
    Task<IEnumerable<UsuariosInvest>> BuscarUsuarios();
    Task DeletarUsuarios(UsuariosInvest usuarios);
}
