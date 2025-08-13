using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Aluno BuscarId(int id)
        {
            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
        }

        public void Inserir(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public void inserir(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            var aluno = BuscarId(id);
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }

        Aluno IAlunoRepositorio.BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepositorio.inserir(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepositorio.Inserir(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepositorio.excluir(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepositorio.Excluir(int id)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepositorio.alterar(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
