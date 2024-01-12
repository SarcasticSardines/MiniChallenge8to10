using MC8to10.Services.RestaurantPickMe;
using Microsoft.AspNetCore.Mvc;

namespace MC8to10.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickMeController : ControllerBase
    {
    private readonly IRestaurantPickMeService _restaurantPickMeService;

    public RestaurantPickMeController(IRestaurantPickMeService restaurantPickMeService)
    {
        _restaurantPickMeService = restaurantPickMeService;
    }

    [HttpPut]
    [Route("GetPrompt")]

    public string GetPrompt()
    {
        return _restaurantPickMeService.GetPrompt();
    }

    [HttpGet]
    [Route("GetFood/{myChoice}")]

    public string GetFood(string myChoice)
    {
        return _restaurantPickMeService.GetFood(myChoice);
    }
}
