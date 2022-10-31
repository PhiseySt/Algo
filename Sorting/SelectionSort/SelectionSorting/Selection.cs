using BenchmarkDotNet.Attributes;

namespace SelectionSorting;

public class Selection
{
    [ParamsSource(nameof(ArraySizes))]
    public int[]? NumArray { get; set; }
    int[] _smallArray = AddRandomElements(200);
    int[] _mediumArray = AddRandomElements(2000);
    int[] _largeArray = AddRandomElements(200000);
    readonly int[] _sortedSmallArray = AddSortedElements(200);
    readonly int[] _sortedMediumArray = AddSortedElements(2000);
    readonly int[] _sortedLargeArray = AddSortedElements(200000);
    public IEnumerable<int[]> ArraySizes => new[] { _sortedSmallArray, _sortedMediumArray, _sortedLargeArray };

    [Benchmark]
    public int[] SortArray()
    {
        var arrayLength = NumArray.Length;

        for (var i = 0; i < arrayLength - 1; i++)
        {
            var smallestVal = i;

            for (var j = i + 1; j < arrayLength; j++)
            {
                if (NumArray[j] < NumArray[smallestVal])
                {
                    smallestVal = j;
                }
            }

            (NumArray[smallestVal], NumArray[i]) = (NumArray[i], NumArray[smallestVal]);
        }
        return NumArray;
    }


    public static int[] AddRandomElements(int size)
    {
        var array = new int[size];
        var rand = new Random();
        const int maxNum = 10000;

        for (var i = 0; i < size; i++)
            array[i] = rand.Next(maxNum + 1);

        return array;
    }

    public static int[] AddSortedElements(int size)
    {
        var array = new int[size];

        for (var i = 0; i < size; i++)
            array[i] = i;

        return array;
    }
}