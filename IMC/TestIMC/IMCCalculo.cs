using IMC;
using Xunit;

namespace TestIMC
{
    public class IMCCalculo
    {
        [Fact]
        public void ContaIMC()
        {
            //Arrange
            double peso = 90;
            double altura = 1.70;
            double imc = 31.14;

            //Act
            var resultado = CalculoIMC.ContaIMC(peso, altura);

            //Assert
            Assert.Equal(imc, resultado);
        }

        [Theory]
        [InlineData(100, 1.60, 39.06)]
        [InlineData(85, 1.82, 25.66)]
        [InlineData(76, 1.75, 24.82)]

        public void ContaIMCLista(double peso, double altura, double imc)
        {
            //Act
            var resultado = CalculoIMC.ContaIMC(peso, altura);

            //Assert
            Assert.Equal(imc, resultado);
        }
    }
}