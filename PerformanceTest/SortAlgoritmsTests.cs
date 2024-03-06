using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SortMachine.Sorts;

namespace PerformanceTest;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SortAlgorithmTests
{
    private ISortAlgorithm? _sortAlgorithm;
    private int[] _randomItems = [];

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random(1000);
        _randomItems = Enumerable.Range(0, 1000).Select(i => random.Next()).ToArray();
    }

    [Benchmark]
    public void BubbleSortTest()
    {
        _sortAlgorithm = new BubbleSort();
        _sortAlgorithm.Sort(_randomItems);
    }

    [Benchmark]
    public void ReverseBubbleSortTest()
    {
        _sortAlgorithm = new ReverseBubbleSort();
        _sortAlgorithm.Sort(_randomItems);
    }

    [Benchmark]
    public void InsertionSortTest()
    {
        _sortAlgorithm = new InsertionSort();
        _sortAlgorithm.Sort(_randomItems);
    }

    [Benchmark]
    public void SelectionSortTest()
    {
        _sortAlgorithm = new SelectionSort();
        _sortAlgorithm.Sort(_randomItems);
    }

    [Benchmark]
    public void HeapSortTest()
    {
        _sortAlgorithm = new HeapSort();
        _sortAlgorithm.Sort(_randomItems);
    }
}