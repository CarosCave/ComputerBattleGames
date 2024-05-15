string input;

Console.WriteLine("***********************************");
Console.WriteLine("*                                 *");
Console.WriteLine("*           Welcome to            *");
Console.WriteLine("*      Computer Battle Games      *");
Console.WriteLine("*                                 *");
Console.WriteLine("* (1) Robot Missile               *");
Console.WriteLine("*                                 *");
Console.WriteLine("*                                 *");
Console.WriteLine("* (Q) Quit the Game               *");
Console.WriteLine("*                                 *");
Console.WriteLine("***********************************");
Console.WriteLine();
Console.Write("Your choice: ");
input = Console.ReadLine();

if (input == "Q" || input == "q")
{
    System.Environment.Exit(0);
}

if (!correct)
{
    Console.WriteLine("Booooooomm...");
    Console.WriteLine("You blew it.");
    Console.WriteLine($"The correct answer was: {secretCode}");
}


}