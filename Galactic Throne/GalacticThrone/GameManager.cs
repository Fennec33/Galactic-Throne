namespace GalacticThrone;
using System;

public static class GameManager
{
    private static EmpireResources _playerEmpire = new EmpireResources();
    public static EmpireResources PlayerEmpire { get; } = _playerEmpire;

    private static void Main()
    {

        ImagePrinter.Title();
        Console.WriteLine("Welcome to the game.");
        PrintBlankLine();
        PlayerEmpire.PrintResources();
        
        
        while (true)
        {
            string? input = Console.ReadLine();

            if (input!.Equals("end", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }

    public static void PrintBlankLine()
    {
        Console.WriteLine(".");
    }
}
                                                                                        
                                                                                        
                                                                                        
