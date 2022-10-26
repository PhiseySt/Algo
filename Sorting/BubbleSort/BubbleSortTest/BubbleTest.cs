using BubbleSort;
using Xunit;

namespace BubbleSortTest
{
    public class BubbleTest
    {
        [Fact]
        public void GivenUnsortedArray_ThenReturnSortedArray()
        {
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            var sortFunction = new Bubble
            {
                NumArray = array
            };

            var sortedArray = sortFunction.SortArray();
            Assert.NotNull(sortedArray);
            Assert.Equal(expected, sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_WhenSortedWithOptimizedBubbleSort_ThenGetSortedArray()
        {
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            var sortFunction = new Bubble
            {
                NumArray = array
            };

            var sortedArray = sortFunction.SortOptimizedArray();

            Assert.NotNull(sortedArray);
            Assert.Equal(expected, sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_CheckInstanceType()
        {
            var sortFunction = new Bubble
            {
                NumArray = Bubble.GenerateRandomNumber(200)
            };

            var sortedArray = sortFunction.SortArray();

            Assert.IsType<int[]>(sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_CheckSortedNotNull()
        {
            var sortFunction = new Bubble
            {
                NumArray = Bubble.GenerateRandomNumber(200)
            };

            var sortedArray = sortFunction.SortArray();

            Assert.NotNull(sortedArray);
        }

    }
}