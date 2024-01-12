namespace MC8to10.Services.RestaurantPickMe;

    public interface IRestaurantPickMeService
    {
        string GetPrompt();
        string GetFood(string myChoice);
    }
