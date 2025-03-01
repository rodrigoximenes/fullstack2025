using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaApp.Dominio;
using MinhaApp.Servico;

namespace MinhaApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly IAlunoServico _alunoServico;

        public AlunoController(IAlunoServico alunoServico)
        {
            _alunoServico = alunoServico;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] Aluno aluno)
        {
            return Ok(_alunoServico.AdicionarAluno(aluno.Nome, aluno.Nota));
        }
    }
}
