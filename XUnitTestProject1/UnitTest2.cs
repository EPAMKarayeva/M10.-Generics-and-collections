using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using M10_2;

namespace XUnitTestProject1
{
    public class UnitTest2
    {
        FileReading file = new FileReading();
        string path = @"C:\Users\Aziza_Karayeva\source\repos\M10\M10_2\Test.txt";

        [Fact(DisplayName ="Check correct count of words")]
        public void TestForCorrectCounting()
        {
            //Arrange
            var str = "Test this sheet.";
            var expected = 3;

            //Act
            var result=file.CountWords(str);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}
