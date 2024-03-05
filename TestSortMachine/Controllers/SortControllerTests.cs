using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SortMachine.Controllers;
using SortMachine.Sorts;
using SortMachine.Storage;

namespace TestSortMachine.Controllers;

public class SortControllerTests
{
    private readonly SortController _sortController;
    private readonly Mock<ISortAlgorithm> _sortAlgorithmMock = new();
    private readonly Mock<IDataManager> _dataManagerMock = new();
    private readonly Mock<ILogger<SortController>> _loggerMock = new();

    public SortControllerTests()
    {
        _sortController = new SortController(_sortAlgorithmMock.Object, _dataManagerMock.Object, _loggerMock.Object);
    }

    [Fact]
    public void LastSortedListTest()
    {
        // Arrange
        _dataManagerMock.Setup(x => x.ReadData()).Returns("123");

        // Act
        var result = _sortController.LastSortedList();

        // Assert
        var requestResult = (OkObjectResult)result;
        Assert.Equal("123", requestResult.Value);
    }

    [Fact]
    public void SortListHappyPathTest()
    {
        // Arrange
        _sortAlgorithmMock.Setup(x => x.Sort(new int[] { 1, 2, 3 }));
        _dataManagerMock.Setup(x => x.WriteData("1 2 3"));

        // Act
        var result = _sortController.SortList("1 2 3");

        // Assert
        _sortAlgorithmMock.Verify(x => x.Sort(new int[] { 1, 2, 3 }), Times.Once);
        _dataManagerMock.Verify(x => x.WriteData("1 2 3"), Times.Once);
        Assert.True(result is OkObjectResult);
    }

    [Fact]
    public void SortListWithoutInput()
    {
        // Arrange
        // Act
        var result = _sortController.SortList("");

        // Assert
        Assert.True(result is BadRequestObjectResult);
    }

    [Fact]
    public void SortListWithInvalidInput()
    {
        // Arrange
        // Act
        var result = _sortController.SortList("asdf");

        // Assert
        Assert.True(result is BadRequestObjectResult);
    }
}