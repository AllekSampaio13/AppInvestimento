using AppInvest.Application.Services.Interfaces;
using AppInvest.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AppInvest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcoesController : Controller
    {
        private readonly IAcoesAppService _acoesAppService;

        public AcoesController(IAcoesAppService acoesAppService)
        {
            _acoesAppService = acoesAppService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarAcoes()
        {
            return Ok(await _acoesAppService.BuscarAcoes());
        }

        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> BuscarAcoesId(int Id)
        {
            var acoes = await _acoesAppService.BuscarAcoesId(Id);
            if (acoes == null) return NotFound("Ação não encontrada!");
            return Ok(await _acoesAppService.BuscarAcoesId(Id));
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarAcoes([FromBody] NovoAcoesViewModel vm)
        {
            var result = await _acoesAppService.CadastrarAcoes(vm);
            if (result == null) return BadRequest("Não foi possível cadastrar nenhuma Ação");
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarAcoes([FromBody] AtualizarAcoesViewModel vm)
        {
            var result = await _acoesAppService.AtualizarAcoes(vm);
            if (result == null) return BadRequest("Não foi possível atualizar esta ação!");
            return Ok(result);
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeletarAcoes(int Id)
        {
            var result = await _acoesAppService.DeletarAcoes(Id);
            if (!result) return BadRequest($"Não foi possível excluir a ação {Id}");
            if (result) return Ok();
            return NotFound();
        }
    }
}