using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeTwoToFour.Service.Add2Numbers;

namespace NguyenTMiniChallengeTwoToFour.Controllers;

[ApiController]
[Route("[controller]")]
    public class Add2NumbersController : ControllerBase
    {
    private readonly IAdd2NumbersService _add2NumbersService;

    public Add2NumbersController(IAdd2NumbersService add2NumbersService)
        {
        _add2NumbersService = add2NumbersService;
    }
        [HttpGet]
        [Route("Adding2Num/{number1}/{number2}")]
    public string Adding2Num(string number1, string number2)
    {
        return _add2NumbersService.Adding2Num(number1, number2);
    }
    }