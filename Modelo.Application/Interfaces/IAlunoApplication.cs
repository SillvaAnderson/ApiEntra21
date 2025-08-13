using Modelo.Domain;

namespace Modelo.Application.Interfaces
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);

        void Inserir(Aluno aluno);

        void Excluir(int id);

        void alterar(Aluno aluno);
    }
}
