using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibo;
using Xunit;

namespace FiboTest
{
    public class FiboCalculatorTest
    {
        [Fact]
        public void Fibonaci_Scenario_Expected()
        {
            // arrange
            var fiboCalculator = new FiboCalculator();

            // act
            var result = fiboCalculator.Fibonaci(5);

            // assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(5,5)]
        [InlineData(6,8)]
        [InlineData(7,13)]
        [InlineData(8,21)]
        public void Fibonaci_ArrangeResults_Success(int number, int expected)
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
