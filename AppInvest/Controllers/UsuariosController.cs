using AppInvest.Application.Services.Interfaces;
using AppInvest.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppInvest.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUsuariosAppService _usuariosAppService;

    public UsuariosController(IUsuariosAppService usuariosAppService)
    {
        _usuariosAppService = usuariosAppService;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarUsuarios()
    {
        return Ok(await _usuariosAppService.BuscarUsuarios());
    }

    [HttpGet]
    [Route("nome")]
    public async Task<IActionResult> BuscarUsuariosNome(string nome)
    {
        var usuarios = await _usuariosAppService.BuscarUsuariosNome(nome);
        if (usuarios == null) return NotFound("Ação não encontrada!");
        return Ok(await _usuariosAppService.BuscarUsuariosNome(nome));
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarUsuarios([FromBody] NovoUsuariosViewModel vm)
    {
        var result = await _usuariosAppService.CadastrarUsuarios(vm);
        if (result == null) return BadRequest("Não foi possível cadastrar nenhuma Ação");
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> AtualizarUsuarios([FromBody] AtualizarUsuariosViewModel vm)
    {
        var result = await _usuariosAppService.AtualizarUsuarios(vm);
        if (result == null) return BadRequest("Não foi possível atualizar esta ação!");
        return Ok(result);
    }

    [HttpDelete]
    [Route("{Id}")]
    public async Task<IActionResult> DeletarUsuarios(int Id)
    {
        var result = await _usuariosAppService.DeletarUsuarios(Id);
        if (!result) return BadRequest($"Não foi possível excluir a ação {Id}");
        if (result) return Ok();
        return NotFound();
    }

}
