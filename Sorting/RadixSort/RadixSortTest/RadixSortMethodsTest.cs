using RadixSort;
using Xunit;

namespace RadixSortTest
{
    public class RadixSortMethodsTest
    {
        [Fact]
        public void GivenUnsortedArray_WhenArrayIsNotEmpty_ThenReturnSortedArray()
        {
            var array = new[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new[] { 1, 20, 49, 57, 73, 99, 133 };
            var sortFunction = new RadixSortMethods();

            var sortedArray = sortFunction.RadixSort(array, array.Length, string.Empty);

            Assert.NotNull(sortedArray);
            Assert.Equal( expected, sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_WhenArrayIsRandomized_ThenCheckInstanceType()
        {
            var sortFunction = new RadixSortMethods();
            var array = RadixSortMethods.CreateRandomArray(200, 0, 200);

            var sortedArray = sortFunction.RadixSort(array, array.Length, string.Empty);

            Assert.IsType<int[]>(sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_WhenArrayIsSorted_ThenResultingArrayIsNotNull()
        {
            var sortFunction = new RadixSortMethods(); ;
            var array = RadixSortMethods.CreateRandomArray(200, 0, 200);

            var sortedArray = sortFunction.RadixSort(array, array.Length, string.Empty);

            Assert.NotNull(sortedArray);
        }

        [Fact]
        public void GivenArray_WhenArrayHasSingleElement_ThenReturnSortedArray()
        {
            var array = new[] { 73 };
            var expected = new[] { 73 };
            var sortFunction = new RadixSortMethods();

            var sortedArray = sortFunction.RadixSort(array, array.Length, string.Empty);

            Assert.NotNull(sortedArray);
            Assert.Equal( expected, sortedArray);
        }
    }
}