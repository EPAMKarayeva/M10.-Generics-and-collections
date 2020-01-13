using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using M10_5;

namespace XUnitTestProject1
{
    public class UnitTest5
    {
        CustomStack customStack = new CustomStack();

        [Fact(DisplayName = "Test add method for stack")]
        public void TestAddInCustomStack()
        {
            //Arrange
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            int expected = 3;

            //Act
            var result = customStack.Count;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test pick method for stack")]
        public void TestAddInCustomQue()
        {
            //Arrange
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            int expected = 3;

            //Act
            var result = customStack.Pick();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test pop method for stack")]
        public void TestPopInCustomQue()
        {
            //Arrange
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(7);
            int expected = 7;

            //Act
            var result = customStack.Pop();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
