using MinhaApp.Dominio;
using MinhaApp.Repositorio;

namespace MinhaApp.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;

        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _repositorio = alunoRepositorio;
        }

        public bool AdicionarAluno(int id, string nome, decimal nota)
        {
            var aluno = new Aluno(id, nome, nota);
            _repositorio.Salvar(aluno);
            return aluno.EstaAprovado();
        }

        public bool AtualizarAluno(Aluno aluno)
        {
            return true;
        }

        public Aluno? ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        public List<Aluno> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        public bool RemoverAluno(int id)
        {
            throw new NotImplementedException();
        }
    }
}
