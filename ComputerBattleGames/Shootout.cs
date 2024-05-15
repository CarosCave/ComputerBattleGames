namespace ComputerBattleGames;

public class Shootout : IGame
{
    private int _time = 500;
    private bool _shootout = false;
    public void printScreen()
    {
        Console.Clear();
        Console.WriteLine("Cowboy Shootout -");
        Console.WriteLine("You are back to back");
        Console.WriteLine("Take 10 paces...");
        Console.WriteLine("Ready?!");
        Console.ReadKey();
    }

    public void gameLoop()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} ...");
            Thread.Sleep(_time);
        }

        Console.WriteLine("He draws...");

        for (int i = 0; i < 20; i++)
        {
            if (Console.KeyAvailable)
            {
                _shootout = true;
            }
            else
            {
                _shootout = false;
            }
            Thread.Sleep(50);
        }
        
        if (Console.KeyAvailable)
        {
            Console.WriteLine("But you shoot first.");
            Console.WriteLine("You killed him.");
        }

        else
        {
            Console.WriteLine("And shoots.");
            Console.WriteLine("You are dead.");
        }
        
        
        
        Console.ReadKey();
        Console.ReadKey();
    }
}