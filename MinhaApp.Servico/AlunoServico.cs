using MinhaApp.Dominio;
using MinhaApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;
        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _repositorio = alunoRepositorio;
        }

        public bool AdicionarAluno(string nome, decimal nota)
        {
            var aluno = new Aluno(nome, nota);
            _repositorio.Salvar(aluno);
            return aluno.EstaAprovado();
        }
    }
}
