using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeTwoToFour.Service.LessOrGreater;

namespace NguyenTMiniChallengeTwoToFour.Controllers;

[ApiController]
[Route("[controller]")]
    public class LessOrGreaterController : ControllerBase
    {
    private readonly ILessOrGreaterService _lessOrGreaterService;

    public LessOrGreaterController(ILessOrGreaterService lessOrGreaterService)
        {
        _lessOrGreaterService = lessOrGreaterService;
        }

    [HttpGet]
    [Route("LessOrGreater/{number1}/{number2}")]
    public string LessOrGreater(string number1, string number2){
        return _lessOrGreaterService.LessOrGreater(number1, number2);
    }
    }
