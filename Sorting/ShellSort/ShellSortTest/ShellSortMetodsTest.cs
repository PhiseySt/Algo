using Xunit;

namespace ShellSortTest;

public class ShellSortMetodsTest
{
    [Fact]
    public void GivenUnsortedArray_WhenArrayIsNotEmpty_ThenReturnSortedArray()
    {
        var array = new[] { 73, 57, 49, 99, 133, 20, 1 };
        var expected = new[] { 1, 20, 49, 57, 73, 99, 133 };
        var sortFunction = new ShellSortMethods();

        var sortedArray = sortFunction.ShellSort(array, array.Length, string.Empty);

        Assert.NotNull(sortedArray);
        Assert.Equal( expected, sortedArray);
    }

    [Fact]
    public void GivenUnsortedArray_WhenArrayIsRandomized_ThenCheckInstanceType()
    {
        var sortFunction = new ShellSortMethods();
        var array = ShellSortMethods.CreateRandomArray(200, 0, 200);

        var sortedArray = sortFunction.ShellSort(array, array.Length, string.Empty);

        Assert.IsType<int[]>(sortedArray);
    }

    [Fact]
    public void GivenUnsortedArray_WhenArrayIsSorted_ThenResultingArrayIsNotNull()
    {
        var sortFunction = new ShellSortMethods(); ;
        var array = ShellSortMethods.CreateRandomArray(200, 0, 200);

        var sortedArray = sortFunction.ShellSort(array, array.Length, string.Empty);

        Assert.NotNull(sortedArray);
    }

    [Fact]
    public void GivenArray_WhenArrayHasSingleElement_ThenReturnSortedArray()
    {
        var array = new[] { 73 };
        var expected = new[] { 73 };
        var sortFunction = new ShellSortMethods();

        var sortedArray = sortFunction.ShellSort(array, array.Length, string.Empty);

        Assert.NotNull(sortedArray);
        Assert.Equal( expected, sortedArray);
    }
}