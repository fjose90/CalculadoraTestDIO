namespace CalculadoraTest;
using Calculadora;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 1, 0)]
    [InlineData(-1, -1, -2)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        int resultadoCalculadora = calc.Somar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(-1, 1, -2)]
    [InlineData(-1, -1, 0)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        int resultadoCalculadora = calc.Subtrair(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(-1, 1, -1)]
    [InlineData(-1, -1, 1)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        int resultadoCalculadora = calc.Multiplicar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(1, 0, -2)]
    [InlineData(-1, -1, -1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        int resultadoCalculadora = calc.Dividir(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
}