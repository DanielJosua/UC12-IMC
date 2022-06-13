using IMC;
using Xunit;

namespace TestIMC
{
    public class IMCGrau
    {
        [Fact]
        public void ClassificacaoIMC()
        {
            //Arrange
            double imc = 19;
            string result = "Peso normal";

            //Act
            var resultado = CalculoIMC.Classificacao(imc);

            //Assert
            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(18, "Baixo peso")]
        [InlineData(22, "Peso normal")]
        [InlineData(26, "Sobrepeso")]

        public void ClassificarIMCLista(double imc, string result)
        {
            //Act
            var resultado = CalculoIMC.Classificacao(imc);

            //Assert
            Assert.Equal(result, resultado);
        }
    }
}
