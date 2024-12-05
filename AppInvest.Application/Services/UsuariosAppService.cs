using AppInvest.Application.Services.Interfaces;
using AppInvest.Application.ViewModel;
using AppInvest.Domain.Interfaces.Services;
using AppInvest.Domain.Models.Command;
using AppInvest.Domain.Models;
using AutoMapper;


namespace AppInvest.Application.Services;

public class UsuariosAppService : IUsuariosAppService
{
    private readonly IUsuariosService _usuariosService;
    private readonly IMapper _Mapper;

    public UsuariosAppService(IUsuariosService usuariosService, IMapper mapper)
    {
        _usuariosService = usuariosService;
        _Mapper = mapper;
    }

    public async Task<IEnumerable<UsuariosViewModel>> BuscarUsuarios()
    {
        return _Mapper.Map<IEnumerable<UsuariosViewModel>>(await _usuariosService.BuscarUsuarios());
    }

    public async Task<IEnumerable<UsuariosViewModel>> BuscarUsuariosNome(string nome)
    {
        var usuarios = await _usuariosService.BuscarUsuariosNome(nome);
        return _Mapper.Map<IEnumerable<UsuariosViewModel>>(usuarios);
    }

    public async Task<UsuariosViewModel> CadastrarUsuarios(NovoUsuariosViewModel novoUsuariosViewModel)
    {
        var novoUsuarios = new UsuariosInvest(novoUsuariosViewModel.Nome,
            novoUsuariosViewModel.Email);

        var UsuariosCadastrado = await _usuariosService.CadastrarUsuarios(novoUsuarios);
        return _Mapper.Map<UsuariosViewModel>(UsuariosCadastrado);

    }

    public async Task<UsuariosViewModel> AtualizarUsuarios(AtualizarUsuariosViewModel atualizarUsuariosViewModel)
    {
        var command = new AtualizarUsuariosCommand
        {
            Id = atualizarUsuariosViewModel.Id,
            Nome = atualizarUsuariosViewModel.Nome,
            Email = atualizarUsuariosViewModel.Email
        };

        var usuariosAtualizado = await _usuariosService.AtualizarUsuarios(command);
        return _Mapper.Map<UsuariosViewModel>(usuariosAtualizado);

    }

    public async Task<bool> DeletarUsuarios(int Id)
    {
        return await _usuariosService.DeletarUsuarios(Id);
    }



}
