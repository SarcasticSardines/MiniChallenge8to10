namespace MC8to10.Services.GuessIt3;

    public interface IGuessIt3Service
    {
        string GamePrompt();

        string GetEasy(string guessA);

        string GetAverage(string guessB);

        string GetHard(string guessC);
    }
