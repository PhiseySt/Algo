using BenchmarkDotNet.Attributes;

namespace BubbleSort;

public class Bubble
{
    [ParamsSource(nameof(ArraySizes))]
    public int[]? NumArray { get; set; }
    int[] _smallArray = GenerateRandomNumber(200);
    int[] _mediumArray = GenerateRandomNumber(2000);
    int[] _largeArray = GenerateRandomNumber(200000);
    int[] _sortedSmallArray = GenerateSortedNumber(200);
    int[] _sortedMediumArray = GenerateSortedNumber(2000);
    int[] _sortedLargeArray = GenerateSortedNumber(200000);
    public IEnumerable<int[]> ArraySizes => new[] { _sortedSmallArray, _sortedMediumArray, _sortedLargeArray };

    [Benchmark]
    public int[] SortArray()
    {
        var n = NumArray.Length;

        for (var i = 0; i < n - 1; i++)
        for (var j = 0; j < n - i - 1; j++)
            if (NumArray[j] > NumArray[j + 1])
            {
                var tempVar = NumArray[j];
                NumArray[j] = NumArray[j + 1];
                NumArray[j + 1] = tempVar;
            }

        return NumArray;
    }

    [Benchmark]
    public int[] SortOptimizedArray()
    {
        var n = NumArray.Length;
        bool swapRequired;

        for (var i = 0; i < n - 1; i++)
        {
            swapRequired = false;
            for (var j = 0; j < n - i - 1; j++)
                if (NumArray[j] > NumArray[j + 1])
                {
                    var tempVar = NumArray[j];
                    NumArray[j] = NumArray[j + 1];
                    NumArray[j + 1] = tempVar;
                    swapRequired = true;
                }
            if (swapRequired == false)
                break;
        }

        return NumArray;
    }

    public static int[] GenerateRandomNumber(int size)
    {
        var array = new int[size];
        var rand = new Random();
        var maxNum = 10000;

        for (int i = 0; i < size; i++)
            array[i] = rand.Next(maxNum + 1);

        return array;
    }

    public static int[] GenerateSortedNumber(int size)
    {
        var array = new int[size];

        for (int i = 0; i < size; i++)
            array[i] = i;

        return array;
    }

}