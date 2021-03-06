using System;
using Xunit;
using LetsTest.Domain;

namespace LetsTest.Tests
{
    public class FluentCalculatorUnitTests
    {
        [Fact]
        public void Pow_IfZero_ReturnsZero()
        {
            //Arrange (Arrumar)
            var expected = 0d;
            var calc = new FluentCalculator();

            // Act (Acionar)
            var actual = calc.Pow(5).Result;

            // Assert (Averiguar)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideBy_Zero_ReturnsNaN()
        {
            //Arrange (Arrumar)
            var calc = new FluentCalculator();
            var expected = double.NaN;

            // Act (Acionar) && Assert (Averiguar)
            var actual = calc.DivideBy(0).Result;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void DivideBy_NByZero_ReturnsInfinity()
        {
            //Arrange (Arrumar)
            var calc = new FluentCalculator();
            var expected = double.PositiveInfinity;

            // Act (Acionar) && Assert (Averiguar)
            var actual = calc.Plus(10).DivideBy(0).Result;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Minus_Negative_ThrowsException()
        {
            //Arrange (Arrumar)
            var expectedMessage = "negative numbers";
            var calc = new FluentCalculator();
            Func<double, FluentCalculator> action = calc.Minus;

            // Act (Acionar)
            var actual = Assert.Throws<ArgumentException>(() => action(-1));

            //Assert(Averiguar)
            Assert.Contains(expectedMessage, actual.Message);
        }
    }
}
