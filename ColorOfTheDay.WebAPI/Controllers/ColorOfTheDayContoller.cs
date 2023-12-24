using Microsoft.AspNetCore.Mvc;

namespace ColorOfTheDay.WebAPI.Controllers;

    [ApiController]
    [Route("[controller]")]
public class ColorOfTheDayController : ControllerBase
{

    private readonly ILogger<ColorOfTheDayController> _logger;

    public ColorOfTheDayController(ILogger<ColorOfTheDayController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetColorOfTheDay")]
    public string Get()
    {         
        switch (DateTime.Today.DayOfWeek)
        {
            case DayOfWeek.Monday:
                return "orange";
            case DayOfWeek.Tuesday:
                return "magenta";
            case DayOfWeek.Wednesday:
                return "yellow";
            case DayOfWeek.Thursday:
                return "green";
            case DayOfWeek.Friday:
                return "lightblue";
            case DayOfWeek.Saturday:
                return "red";
            case DayOfWeek.Sunday:
                return "darkblue";
            default:
                return "white";
        }
    }
}
