using ComputerBattleGames;

class RobotMissile : IGame
{
    private static Random _rand = new Random();
    private string? _tryCode;
    private int _check;
    private bool _correct = false;

    private static string _secretCode = ((char)_rand.Next('A', 'Z' + 1)).ToString();


    public void printScreen()
    {
        Console.Clear();
        //Console.WriteLine(_secretCode);

        Console.WriteLine("Robot Missile");
        Console.WriteLine();
        Console.WriteLine("Type the correct code");
        Console.WriteLine("Letter (A-Z) to");
        Console.WriteLine("defuse the missile.");
        Console.WriteLine("You have 4 chances.");
    }

    public void gameLoop()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.Write($"Your {i}. try: ");
            _tryCode = Console.ReadLine().ToUpper();

            // string.compare("a", "b") = -1
            // string.compare("b", "a") = 1
            // string.compare("a", "a") = 0
            _check = string.Compare(_secretCode, _tryCode);


            if (_check == 0)
            {
                Console.WriteLine("Tick... Fzzz... Click...");
                Console.WriteLine("You did it!");
                if (i == 4)
                {
                    Console.WriteLine("Just!");
                }

                Console.ReadKey();
                _correct = true;
                break;
            }

            if (_check == 1 && i < 4)
            {
                Console.WriteLine("Later");
                _correct = false;
            }

            if (_check == -1 && i < 4)
            {
                Console.WriteLine("Earlier");
                _correct = false;
            }
            
            if (!_correct)
            {
                Console.WriteLine("Booooooomm...");
                Console.WriteLine("You blew it.");
                Console.WriteLine($"The correct answer was: {_secretCode}");
                Console.ReadKey();
            }
        }
    }
}