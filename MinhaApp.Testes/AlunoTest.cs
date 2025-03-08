using MinhaApp.Dominio;

namespace MinhaApp.Testes
{
    public class AlunoTest
    {
        [Fact]
        public void Aluno_DeveSerAprovado_ComNota_MaiorQue7()
        {
            //AAA - Arrange Act Assert

            //Arrange
            var aluno = new Aluno(1, "Rodrigo", 10);

            //Act
            var resultado = aluno.EstaAprovado();

            //Assert
            Assert.True(resultado);
        }
    }
}