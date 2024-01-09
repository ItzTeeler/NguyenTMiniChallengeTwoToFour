using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeTwoToFour.Service.Ask2Questions;

namespace NguyenTMiniChallengeTwoToFour.Controllers;

[ApiController]
[Route("[controller]")]
    public class Ask2QuestionsController : ControllerBase
    {
    private readonly IAsk2QuestionsService _ask2QuestionsService;

    public Ask2QuestionsController(IAsk2QuestionsService ask2QuestionsService)
        {
        _ask2QuestionsService = ask2QuestionsService;
        }
    
    [HttpGet]
    [Route("Ask2Questions/{Whatisyourname}/{Whattimedidyouwakeup}")]
    public string Ask2Questions(string Whatisyourname, string Whattimedidyouwakeup)
    {
        return _ask2QuestionsService.Ask2Questions(Whatisyourname, Whattimedidyouwakeup);
    }
    }
