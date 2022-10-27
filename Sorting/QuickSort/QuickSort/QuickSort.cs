using BenchmarkDotNet.Attributes;

namespace QuickSort;

public class QuickSort
{
    public IEnumerable<object[]> SampleArrays()
    {
        yield return new object[] { CreateRandomArray(200), 0, 199, "Small Unsorted" };
        yield return new object[] { CreateRandomArray(2000), 0, 1999, "Medium Unsorted" };
        yield return new object[] { CreateRandomArray(10000), 0, 9999, "Large Unsorted" };
        yield return new object[] { CreateSortedArray(200), 0, 199, "Small Sorted" };
        yield return new object[] { CreateSortedArray(2000), 0, 1999, "Medium Sorted" };
        yield return new object[] { CreateSortedArray(10000), 0, 9999, "Large Sorted" };
    }

    [Benchmark]
    [ArgumentsSource(nameof(SampleArrays))]
    public int[] SortArray(int[] array, int minIndex, int maxIndex, string name)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

        SortArray(array, minIndex, pivotIndex - 1, name);

        SortArray(array, pivotIndex + 1, maxIndex, name);

        return array;
    }

    private int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);

        return pivot;
    }

    private void Swap(ref int leftItem, ref int rightItem)
    {
        (leftItem, rightItem) = (rightItem, leftItem);
    }

    public static int[] CreateRandomArray(int size)
    {
        var array = new int[size];
        var rand = new Random();

        for (int i = 0; i < size; i++)
            array[i] = rand.Next();

        return array;
    }
    public static int[] CreateSortedArray(int size)
    {
        var array = new int[size];

        for (int i = 0; i < size; i++)
            array[i] = i;

        return array;
    }
}