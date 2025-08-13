using Modelo.Application.Interfaces;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;


namespace Modelo.Application
{
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoApplication(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Aluno BuscarAluno(int id)
        {
            return _alunoRepositorio.BuscarId(id);
        }
        public void Inserir(Aluno aluno)
        {
            _alunoRepositorio.Inserir(aluno);
        }

        public void Excluir(int id)
        {
            _alunoRepositorio.Excluir(id);
        }

        public void alterar(Aluno aluno)
        {
            _alunoRepositorio.alterar(aluno);
        }
    }
}
