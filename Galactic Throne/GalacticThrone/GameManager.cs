namespace GalacticThrone;
using System;

public static class GameManager
{
    private static void Main()
    {
        ImagePrinter.Title();
        Console.WriteLine("Welcome to the game.");
        
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
                                                                                        
                                                                                        
                                                                                        
