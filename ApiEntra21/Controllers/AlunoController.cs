using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interfaces;
using Modelo.Domain;

namespace ApiEntra21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IAlunoApplication _alunoApplication;

        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }

        [HttpGet("BuscarDadosAluno/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);

                return Ok(aluno);

            }
            catch (Exception e)
            {

                return BadRequest();
            }


        }

        [HttpPost("Inserir")]
        public IActionResult Inserir([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.Inserir(aluno);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _alunoApplication.Excluir(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPatch("Alterar")]
        public IActionResult Alterar([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.alterar(aluno);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
