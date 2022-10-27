using Xunit;

namespace QuickSortTest;

public class QuickSortTest
{
    [Fact]
    public void GivenUnsortedArray_WhenArrayIsNotEmpty_ThenReturnSortedArray()
    {
        var array = new int[] { 73, 57, 49, 99, 133, 20, 1, 73, 57, 49, 99, 133, 20, 1 };
        var expected = new int[] { 1, 1, 20, 20, 49, 49, 57, 57, 73, 73, 99, 99, 133, 133 };

        var sortFunction = new QuickSort.QuickSort();

        var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1, string.Empty);

        Assert.NotNull(sortedArray);
        Assert.Equal(expected, sortedArray);
    }

    [Fact]
    public void GivenUnsortedArray_WhenArrayIsNotEmpty_ThenCheckInstanceType()
    {
        var sortFunction = new QuickSort.QuickSort();
        var array = QuickSort.QuickSort.CreateRandomArray(200);

        var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1, string.Empty);

        Assert.IsType<int[]>(sortedArray);
    }

    [Fact]
    public void GivenUnsortedArray_WhenArrayIsSorted_ThenResultingArrayIsNotNull()
    {
        var sortFunction = new QuickSort.QuickSort();
        var array = QuickSort.QuickSort.CreateRandomArray(5);

        var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1, string.Empty);

        Assert.NotNull(sortedArray);
    }
} 
