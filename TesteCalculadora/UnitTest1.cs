using CalculadoraDio;
using System;
using Xunit;

namespace TesteCalculadora
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData (2, 2, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 5, 25)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarHistorico() 
        { 
            Calculadora calc = new Calculadora();
            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(3, 2);
            calc.Somar(4, 2);
            calc.Somar(5, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}
