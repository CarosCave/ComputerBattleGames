using ComputerBattleGames;

string input;
IGame? game = null;

while (true)
{
    printMainMenu();
    input = inputMainMenu();

    switch (input)
    {
        case "1":
            game = new RobotMissile();
            break;
        case "2":
            game = new Shootout();
            break;
        case "q":
        case "Q":
            Environment.Exit(1);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please use only 1-10 or Q.");
            Console.ReadKey();
            break;
    }

    if (game != null)
    {
        game.printScreen();
        game.gameLoop();
    }
    
}


void printMainMenu()
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("*                                 *");
    Console.WriteLine("*           Welcome to            *");
    Console.WriteLine("*      Computer Battle Games      *");
    Console.WriteLine("*                                 *");
    Console.WriteLine("* (1) Robot Missile               *");
    Console.WriteLine("* (2) Shootout                    *");
    Console.WriteLine("*                                 *");
    Console.WriteLine("*                                 *");
    Console.WriteLine("* (Q) Quit the Game               *");
    Console.WriteLine("*                                 *");
    Console.WriteLine("***********************************");
    Console.WriteLine();
}

string inputMainMenu()
{
    Console.Write("Your choice: ");
    return Console.ReadLine();
}





