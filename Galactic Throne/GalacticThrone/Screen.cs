namespace GalacticThrone;

public static class Screen
{
    public static void Print(string s)
    {
        Console.WriteLine(s);
    }

    public static void Clear()
    {
        Console.Clear();
    }

    public static string GetInput()
    {
        return Console.ReadLine()!;
    }
    
    public static void PrintBlankLine()
    {
        Console.WriteLine(".");
    }
    
    public static void PrintInputError()
    {
        PrintBlankLine();
        Console.WriteLine("Sorry but that command was not recognised. " +
                          "If you are having trouble, type in \"help\"" +
                          " for more assistance.");
        PrintBlankLine();
    }
}