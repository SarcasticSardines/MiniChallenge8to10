namespace MC8to10.Services.GuessIt3;

    public class GuessItService : IGuessIt3Service
    {
        public string GamePrompt()
        {
            return "This is a guessing game with numbers! The number you enter will be your guess of what the \"secret\" number is. In easy mode the number range you have to guess between is 1-10, in medium mode it is 1-50, and in hard mode it is 1-100. Only whole numbers within the designated ranges will be accepted. Good luck!";
        }

        public string GetEasy(string guessA)
        {
            int num = 0;
            bool validGuess = int.TryParse(guessA, out num);

            if(validGuess == true)
            {
                   Random random = new Random();
                    int answer = random.Next(0, 11);

                    if(num == answer)
                    {
                        return $"{answer} is the secret number! You've won!";
                    }else if(num > answer)
                    {
                        return $"{num} is too high.";
                    }else
                    {
                        return $"{num} is too low.";
                    }
            }else{
                return "Please input a valid whole number value between 1 and 10.";
            }
        }

        public string GetAverage(string guessB)
        {
            int num = 0;
            bool validGuess = int.TryParse(guessB, out num);

            if(validGuess == true)
            {
            Random random = new Random();
            int answer = random.Next(0, 51);

            if(num == answer)
                    {
                        return $"{answer} is the secret number! You've won!";
                    }else if(num > answer)
                    {
                        return $"{num} is too high.";
                    }else
                    {
                        return $"{num} is too low.";
                    }
            }else{
                return "Please input a valid whole number value between 1 and 50.";
            }
        }

        public string GetHard(string guessC)
        {
            int num = 0;
            bool validGuess = int.TryParse(guessC, out num);

            if(validGuess == true)
            {
            Random random = new Random();
            int answer = random.Next(0, 101);

            if(num == answer)
                    {
                        return $"{answer} is the secret number! You've won!";
                    }else if(num > answer)
                    {
                        return $"{num} is too high.";
                    }else
                    {
                        return $"{num} is too low.";
                    }
            }else{
                return "Please input a valid whole number value between 1 and 100.";
            }
        }

    }
