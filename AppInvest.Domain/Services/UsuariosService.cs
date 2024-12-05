using AppInvest.Domain.Interfaces.Repositories;
using AppInvest.Domain.Models.Command;
using AppInvest.Domain.Models;
using AppInvest.Domain.Interfaces.Services;

namespace AppInvest.Domain.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuariosRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public async Task<IEnumerable<UsuariosInvest>> BuscarUsuarios()
        {
            return await _usuariosRepository.BuscarUsuarios();
        }

        public async Task<IEnumerable<UsuariosInvest>> BuscarUsuariosNome(string nome)
        {
            return await _usuariosRepository.BuscarUsuariosNome(nome);
        }

        public async Task<UsuariosInvest> CadastrarUsuarios(UsuariosInvest usuarios)
        {
            await _usuariosRepository.CadastrarUsuarios(usuarios);
            await _usuariosRepository.UnitOfWork.SaveChangesAsync();

            return usuarios;
        }

        public async Task<UsuariosInvest> AtualizarUsuarios(AtualizarUsuariosCommand command)
        {
            var usuarios = await _usuariosRepository.Get(x => x.Id == command.Id);
            if (usuarios == null) return null;

            usuarios.Atualizar(command.Nome,
                command.Email);

            await _usuariosRepository.AtualizarUsuarios(usuarios);
            await _usuariosRepository.UnitOfWork.SaveChangesAsync();
            return usuarios;

        }

        public async Task<bool> DeletarUsuarios(int Id)
        {
            var usuarios = await _usuariosRepository.Get(x => x.Id == Id);
            if (usuarios == null) return false;

            await _usuariosRepository.DeletarUsuarios(usuarios);
            await _usuariosRepository.UnitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
