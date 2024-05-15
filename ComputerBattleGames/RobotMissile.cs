class RobotMissile
{
    Random rand = new Random();
    private string _tryCode;
    int check;
    bool correct = false;

    private string _secretCode = ((char)rand.Next('A', 'Z' + 1)).ToString();

    
    Console.WriteLine(secretCode);

    Console.WriteLine("Robot Missile");
    Console.WriteLine();
    Console.WriteLine("Type the correct code");
    Console.WriteLine("Letter (A-Z) to");
    Console.WriteLine("defuse the missile.");
    Console.WriteLine("You have 4 chances.");

    for (int i = 1; i < 5; i++)
    {
        Console.Write($"Your {i}. try: ");
        _tryCode = Console.ReadLine().ToUpper();
    
        // string.compare("a", "b") = -1
        // string.compare("b", "a") = 1
        // string.compare("a", "a") = 0
        check = string.Compare(_secretCode, _tryCode);

    
        if (check == 0)
        {
            Console.WriteLine("Tick... Fzzz... Click...");
            Console.WriteLine("You did it!");
            if (i == 4)
            {
                Console.WriteLine("Just!");
            }

            correct = true;
            break;
        }

        if (check == 1 && i < 4)
        {
            Console.WriteLine("Later");
            correct = false;
        }

        if (check == -1 && i < 4)
        {
            Console.WriteLine("Earlier");
            correct = false;
        }
    }