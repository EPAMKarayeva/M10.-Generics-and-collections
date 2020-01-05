using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using M10_3;


namespace XUnitTestProject1
{
    public class UnitTest3
    {
        FibonacciRow fibonacci = new FibonacciRow();

        [Fact(DisplayName ="Check for correct finding number")]
        public void TestCorrectLastNumberInFibonacciRow()
        {
            //Arrange
            int n = 9;
            int expected = 34;

            //Act
            var result = fibonacci.CountNumbers(n).Last();

            //Assert
            Assert.Equal(expected, result);        

        }
    }
}
