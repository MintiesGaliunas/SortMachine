using Microsoft.AspNetCore.Mvc;
using SortMachine.Sorts;
using SortMachine.Storage;
using System.Data;

namespace SortMachine.Controllers;

public class SortController : ControllerBase
{

    private readonly ILogger<SortController> _logger;
    private readonly ISortAlgorithm _sortAlgorithm;
    private readonly IDataManager _fileDataManager;
    public SortController(ISortAlgorithm sortAlgorithm, IDataManager fileDataManager, ILogger<SortController> logger)
    {
        _sortAlgorithm = sortAlgorithm;
        _fileDataManager = fileDataManager;
        _logger = logger;
    }

    [HttpPost("[controller]")]
    [ProducesResponseType<string>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult SortList(string input)
    {
        try
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            var list = input.Split(" ").Select(text => int.TryParse(text, out int value) ? value : throw new ArgumentException()).ToArray();
            _sortAlgorithm.Sort(list);
            var result = string.Join(" ", list);
            _fileDataManager.WriteData(result);
            return Ok(result);
        }
        catch (ArgumentException ex) {
            _logger.LogError(ex.Message + "Provided input: " + input);
            return BadRequest("Please enter a queue of number separated by spaces as input");
        }
    }

    [HttpGet("[controller]")]
    [ProducesResponseType<string>(StatusCodes.Status200OK)]
    public IActionResult LastSortedList()
    {
        return Ok(_fileDataManager.ReadData());
    }

}