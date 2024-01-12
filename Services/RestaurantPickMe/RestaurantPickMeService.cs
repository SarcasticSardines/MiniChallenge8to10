namespace MC8to10.Services.RestaurantPickMe;

    public class RestaurantPickMeService : IRestaurantPickMeService
    {
        public string GetPrompt()
        {
            return "To use the GetFood API, please enter a whole number between 1 and 3 to choose a food category. 1 is for fast food, 2 is for seafood, and 3 is for vegetarian food. The API will return a random restaurant out of a list of 10 that serves and specializes in the chosen category of food.";
        }
        public string GetFood(string myChoice)
        {
            if(myChoice == "1")
            {
                string[] fastFood = {"In-N-Out", "Burger King", "Jack in the Box", "KFC", "Popeyes", "Sonic", "Cracker Barrel", "Taco Bell", "Carls Jr", "Wienerschnitzel"};
                Random random = new Random();
                int foodresult = random.Next(0, fastFood.Length);
                return fastFood[foodresult];
            }else if(myChoice == "2")
            {
                string[] seaFood = {"Long John Silvers", "La Petit Poisson", "Matsuyama Sushi", "Captain Crab", "Red Lobster", "Bubba Gump Shrimp Co.", "Surf N Turf", "Rubios", "Fish N Chips", "Holy Mackarel"};
                Random random = new Random();
                int foodresult = random.Next(0, seaFood.Length);
                return seaFood[foodresult];
            }else if(myChoice == "3")
            {
                string[] vegFood = {"Lettuce Lounge", "Vegan Palace", "Healthie House", "Cabbage Cottage", "Broccoli Bunker", "Spinach Safehouse", "House of Veggies", "Grandma's Garden", "Eggplant Manor", "Casa de Cebolla"};
                Random random = new Random();
                int foodresult = random.Next(0, vegFood.Length);
                return vegFood[foodresult];
            }else{
                return "Invalid input detected, please only enter a whole number value between 1 and 3.";
            }
        }

    }
