using System;
using Xunit;
using M10;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        BinarySearch binarySearch = new BinarySearch();

        [Fact(DisplayName ="Testing correct result for binary search")]
        public void TestForCorrectBinarySearch()
        {
            //Arrange
            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10 };

            var expected = true;

            //Act
            var result=binarySearch.BinarySearching(4, array);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}
