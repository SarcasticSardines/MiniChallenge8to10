using MC8to10.Services.Magic8B;
using Microsoft.AspNetCore.Mvc;

namespace MC8to10.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class Magic8BController : ControllerBase
    {
    private readonly IMagic8BService _magic8BService;

    public Magic8BController(IMagic8BService magic8BService)
    {
        _magic8BService = magic8BService;
    }

    [HttpGet]
    [Route("GetMagic/{myQuestion}")]

    public string GetMagic(string myQuestion)
    {
        return _magic8BService.GetMagic(myQuestion);
    }
}
