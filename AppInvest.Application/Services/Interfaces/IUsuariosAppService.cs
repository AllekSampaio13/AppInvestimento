using AppInvest.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Application.Services.Interfaces;

public interface IUsuariosAppService
{
    Task<UsuariosViewModel> CadastrarUsuarios(NovoUsuariosViewModel novoUsuariosViewModel);
    Task<UsuariosViewModel> AtualizarUsuarios(AtualizarUsuariosViewModel atualizarUsuariosViewModel);
    Task<IEnumerable<UsuariosViewModel>> BuscarUsuarios();
    Task<IEnumerable<UsuariosViewModel>> BuscarUsuariosNome(string nome);
    Task<bool> DeletarUsuarios(int Id);
}
