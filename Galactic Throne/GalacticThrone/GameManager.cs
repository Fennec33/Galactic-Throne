namespace GalacticThrone;
using System;

public static class GameManager
{
    private static void Main()
    {
        Console.WriteLine("Start");
        
        while (true)
        {
            string? input = Console.ReadLine();

            if (input!.Equals("end", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}
