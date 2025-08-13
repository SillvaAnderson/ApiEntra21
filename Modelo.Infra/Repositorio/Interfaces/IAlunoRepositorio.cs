using Modelo.Domain;

namespace Modelo.Infra.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarId(int id);

        void inserir(Aluno aluno);
        void Inserir(Aluno aluno);

        void excluir(Aluno aluno);
        void Excluir(int id);
        void alterar(Aluno aluno);
    }
}
