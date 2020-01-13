using System;
using System.Collections.Generic;
using System.Text;
using M10_4;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest4
    {
        CustomQueue customQueue = new CustomQueue();

        [Fact(DisplayName ="Test add method for que")]
        public void TestAddInCustomQue()
        {
            //Arrange
            customQueue.Add(1);
            customQueue.Add(2);
            int expected = 2;

            //Act
            var result= customQueue.Count;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test pick method for que")]
        public void TestPickFromCustomQue()
        {
            //Arrange
            customQueue.Add(4);
            customQueue.Add(2);
            customQueue.Add(3);
            int expected = 4;

            //Act
            var result = customQueue.PickFirstQue();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test delete method for que")]
        public void TestDeleteFromCustomQue()
        {
            //Arrange
            customQueue.Add(4);
            customQueue.Add(2);
            customQueue.Add(5);
            customQueue.Add(3);
            int expected = 4;

            //Act
            var result = customQueue.DeleteFromQue();

            //Assert
            Assert.Equal(expected, result);
        }


    }
}
