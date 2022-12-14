using MergeSort;
using Xunit;

namespace MergeSortTest
{
    public class MergeTest
    {
        [Fact]
        public void GivenUnsortedArray_ThenReturnSortedArray()
        {
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            var sortFunction = new Merge();

            var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1, string.Empty);

            Assert.NotNull(sortedArray);
            Assert.Equal(expected, sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_CheckInstanceType()
        {
            var sortFunction = new Merge();
            var array = Merge.GenerateRandomNumber(200);

            var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1, string.Empty);

            Assert.IsType<int[]>(sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_CheckSortedNotNull()
        {
            var sortFunction = new Merge();
            var array = Merge.GenerateRandomNumber(200);

            var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1, string.Empty);

            Assert.NotNull(sortedArray);
        }
    }
}