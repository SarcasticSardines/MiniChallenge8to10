using MC8to10.Services.GuessIt3;
using Microsoft.AspNetCore.Mvc;

namespace MC8to10.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class GuessIt3Controller : ControllerBase
    {
    private readonly IGuessIt3Service _guessIt3Service;

    public GuessIt3Controller(IGuessIt3Service guessIt3Service)
    {
        _guessIt3Service = guessIt3Service;
    }

    [HttpPut]
    [Route("GamePrompt")]

    public string GamePrompt()
    {
        return _guessIt3Service.GamePrompt();
    }

    [HttpGet]
    [Route("GetEasy/{guessA}")]

    public string GetEasy(string guessA)
    {
        return _guessIt3Service.GetEasy(guessA);
    }

    [HttpGet]
    [Route("GetAverage/{guessB}")]

    public string GetAverage(string guessB)
    {
        return _guessIt3Service.GetAverage(guessB);
    }

    [HttpGet]
    [Route("GetHard/{guessC}")]

    public string GetHard(string guessC)
    {
        return _guessIt3Service.GetHard(guessC);
    }
}
