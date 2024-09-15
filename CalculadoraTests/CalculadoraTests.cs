using System.Runtime.CompilerServices;
using Calculadora.Services;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImplementacao();
    }
        
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = this._calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }
        
    [Fact]
    public void DeveSubtrair20De50ERetornar30()
    {
        // Arrange
        int num1 = 50;
        int num2 = 20;

        // Act
        int resultado = this._calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        // Arrange
        int num = 4;

        // Act
        bool result = this._calc.EhPar(num);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    [InlineData(220)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        // Act
        bool result = this._calc.EhPar(numero);

        // Arrange
        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiroArray(int[] numeros)
    {
        // Act / Arrange
        Assert.All(numeros, num => Assert.True(this._calc.EhPar(num)));
    }
}