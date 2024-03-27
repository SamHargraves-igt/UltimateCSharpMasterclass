DiceRollGame game = new DiceRollGame();
int count = 3;

while (count > 0)
{

    while (!game.StartGame())
    {
        game.StartGame();
    }

    if (game.CheckWin())
    {
        Console.WriteLine("Yay you won");
        Console.ReadKey();
        break;
    }
    Console.WriteLine($"Unlucky. {count - 1} goes left");
    count--;
}

Console.WriteLine("Try again next time");
Console.ReadKey();


class DiceRollGame
{
    IsInputValid IsValid = new IsInputValid();
    private string Input;
    public bool StartGame()
    {
        Console.WriteLine("Guess a Number (1-6):");
        Input = Console.ReadLine();

        bool checkinput = IsValid.CheckInput(Input);

        return checkinput;
    }
    public bool CheckWin()
    {
        RandomDiceRoll DiceRoll = new RandomDiceRoll();
        int Roll = DiceRoll.Roll;

        int Int_Input = int.Parse(Input);

        bool checkguess = IsValid.CheckGuess(Int_Input, Roll);

        return checkguess;
    }


}

class RandomDiceRoll
{
    private Random Random = new Random();
    public int Roll { get; private set; }
    public RandomDiceRoll()
    {
        Roll = Random.Next(0, 7);
    }

}

class IsInputValid
{
    private string[] Rolls = { "1", "2", "3", "4", "5", "6"};
    public bool CheckInput(string input)
    {
        if (Rolls.Contains(input)) 
        {
            return true;
        }
        return false;
    }
    public bool CheckGuess(int input, int Roll)
    {
        if (input == Roll)
        {
            return true;
        }
        return false;
    }
}


