using Fibo;
using Xunit;

namespace FiboTest
{
    public class FiboCalculatorTestTdd
    {
        [Theory]
        [InlineData(5,5)]
        [InlineData(6,8)]
        public void Fibonaci_Scenario_Expected(int number, int expected)
        {
            // arrange
            var fiboCalculator = new FiboCalculator();

            // act
            var result = fiboCalculator.Fibonaci(number);

            // assert
            Assert.Equal(expected, result);
        }
    }
}