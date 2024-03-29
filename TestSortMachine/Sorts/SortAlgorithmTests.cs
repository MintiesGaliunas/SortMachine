﻿using SortMachine.Sorts;

namespace TestSortMachine.Sorts;

public class SortAlgorithmTests
{
    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
    public void BubbleSortTest(int[] disorderedList, int[] orderedList)
    {
        // Arrange
        var bubbleSort = new BubbleSort();

        // Act
        bubbleSort.Sort(disorderedList);

        // Arrange
        Assert.Equal(orderedList, disorderedList);
    }

    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
    public void InsertionSortTest(int[] disorderedList, int[] orderedList)
    {
        // Arrange
        var insertionSort = new InsertionSort();

        // Act
        insertionSort.Sort(disorderedList);

        // Assert
        Assert.Equal(orderedList, disorderedList);
    }

    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
    public void ReverseBubbleSortTest(int[] disorderedList, int[] orderedList)
    {
        // Arrange
        var reverseBubbleSort = new ReverseBubbleSort();

        // Act
        reverseBubbleSort.Sort(disorderedList);

        // Assert
        Assert.Equal(orderedList, disorderedList);
    }

    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
    public void SelectonSortTest(int[] disorderedList, int[] orderedList)
    {
        // Arrange
        var selectionSort = new SelectionSort();

        // Act
        selectionSort.Sort(disorderedList);

        // Assert
        Assert.Equal(orderedList, disorderedList);
    }

    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
    public void HeapSortTest(int[] disorderedList, int[] orderedList)
    {
        // Arrange
        var heapSort = new HeapSort();

        // Act
        heapSort.Sort(disorderedList);

        // Assert
        Assert.Equal(orderedList, disorderedList);
    }
}