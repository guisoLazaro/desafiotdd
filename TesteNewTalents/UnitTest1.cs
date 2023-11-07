using NewTalents;

namespace TesteNewTalents
{
    public class UnitTest1
    {

        public Calculadora construitClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construitClasse();

            int resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construitClasse();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construitClasse();

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(5, 4, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construitClasse();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construitClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construitClasse();
            calc.somar(1, 2);
            calc.somar(2, 2);
            calc.somar(3, 2);
            calc.somar(4, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}