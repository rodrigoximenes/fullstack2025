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
            return Ok(_alunoServico.AdicionarAluno(aluno.Id, aluno.Nome, aluno.Nota));
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var aluno = _alunoServico.ObterPorId(id);

            if(aluno == null)
            {
                return NotFound("Aluno não encontrado");
            }

            return Ok(aluno);
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var alunos = _alunoServico.ObterTodos();
            return Ok(alunos);
        }
    }
}
