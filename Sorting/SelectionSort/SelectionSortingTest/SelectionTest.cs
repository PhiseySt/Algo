using SelectionSorting;
using Xunit;


namespace SelectionSortingTest
{
    public class SelectionTest
    {
        [Fact]
        public void GivenUnsortedArray_ThenReturnSortedArray()
        {
            var array = new[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new[] { 1, 20, 49, 57, 73, 99, 133 };
            var sortFunction = new Selection
            {
                NumArray = array
            };

            var sortedArray = sortFunction.SortArray();

            Assert.NotNull(sortedArray);
            Assert.Equal(expected, sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_CheckInstanceType()
        {
            var sortFunction = new Selection
            {
                NumArray = Selection.AddRandomElements(200)
            };

            var sortedArray = sortFunction.SortArray();

            Assert.IsType<int[]>(sortedArray);
        }

        [Fact]
        public void GivenUnsortedArray_CheckSortedNotNull()
        {
            var sortFunction = new Selection
            {
                NumArray = Selection.AddRandomElements(200)
            };

            var sortedArray = sortFunction.SortArray();

            Assert.NotNull(sortedArray);
        }
    }
}