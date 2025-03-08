using MinhaApp.Dominio;

namespace MinhaApp.Servico
{
    public interface IAlunoServico
    {
        bool AdicionarAluno(int id, string nome, decimal nota);
        List<Aluno> ObterTodos();
        Aluno? ObterPorId(int id);
        bool AtualizarAluno(Aluno aluno);
        bool RemoverAluno(int id);
    }
}
