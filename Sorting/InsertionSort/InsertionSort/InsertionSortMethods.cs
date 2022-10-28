using BenchmarkDotNet.Attributes;

namespace InsertionSort;

public class InsertionSortMethods
{
    public IEnumerable<object[]> SampleArrays()
    {
        yield return new object[] { CreateRandomArray(200), 200, "Small Unsorted" };
        yield return new object[] { CreateRandomArray(2000), 2000, "Medium Unsorted" };
        yield return new object[] { CreateRandomArray(20000), 20000, "Large Unsorted" };
        yield return new object[] { CreateSortedArray(200), 200, "Small Sorted" };
        yield return new object[] { CreateSortedArray(2000), 2000, "Medium Sorted" };
        yield return new object[] { CreateSortedArray(20000), 20000, "Large Sorted" };
        yield return new object[] { CreateReversedArray(CreateSortedArray(200)), 200, "Small Reversed" };
        yield return new object[] { CreateReversedArray(CreateSortedArray(2000)), 2000, "Medium Reversed" };
        yield return new object[] { CreateReversedArray(CreateSortedArray(20000)), 20000, "Large Reversed" };
    }

    public static int[] CreateRandomArray(int size)
    {
        var array = new int[size];
        var rand = new Random();

        for (int i = 0; i < size; i++)
            array[i] = rand.Next();

        return array;
    }

    [Benchmark]
    [ArgumentsSource(nameof(SampleArrays))]
    public int[] SortArray(int[] array, int length, string arrayName)
    {

        int x;
        int j;
        for (int i = 1; i < length; i++)
        {
            x = array[i];
            j = i;
            while (j > 0 && array[j - 1] > x)
            {
                Swap(array, j, j - 1);
                j -= 1;
            }
            array[j] = x;
        }

        return array;
    }

    static void Swap(int[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }

    public static int[] CreateSortedArray(int size)
    {
        var array = new int[size];

        for (int i = 0; i < size; i++)
            array[i] = i;

        return array;
    }

    public static int[] CreateReversedArray(int[] array)
    {
        Array.Reverse(array);

        return array;
    }

}