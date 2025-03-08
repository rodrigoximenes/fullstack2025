using MinhaApp.Dominio;

namespace MinhaApp.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Salvar(Aluno aluno);
        List<Aluno> ObterTodos();
        Aluno? ObterPorId(int id);
    }
}
