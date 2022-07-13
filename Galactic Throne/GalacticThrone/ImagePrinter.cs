namespace GalacticThrone;

public static class ImagePrinter
{
    public static void Title()
    {
        Screen.PrintBlankLine();
        Screen.Print("  ██████   █████  ██       █████   ██████ ████████ ██  ██████");
        Screen.Print(" ██       ██   ██ ██      ██   ██ ██         ██    ██ ██     ");
        Screen.Print(" ██   ███ ███████ ██      ███████ ██         ██    ██ ██     ");
        Screen.Print(" ██    ██ ██   ██ ██      ██   ██ ██         ██    ██ ██     ");
        Screen.Print("  ██████  ██   ██ ███████ ██   ██  ██████    ██    ██  ██████");
        Screen.PrintBlankLine();
        Screen.Print("     ████████ ██   ██ ██████   ██████  ███    ██ ███████ ");
        Screen.Print("        ██    ██   ██ ██   ██ ██    ██ ████   ██ ██      ");
        Screen.Print("        ██    ███████ ██████  ██    ██ ██ ██  ██ █████   ");
        Screen.Print("        ██    ██   ██ ██   ██ ██    ██ ██  ██ ██ ██      ");
        Screen.Print("        ██    ██   ██ ██   ██  ██████  ██   ████ ███████ ");
        Screen.PrintBlankLine();
    }

    public static void Help()
    {
        Screen.PrintBlankLine();
        Screen.Print("This is the help page");
        Screen.PrintBlankLine();
        Screen.Print("\"quit\" to end game.");
        Screen.PrintBlankLine();
    }
}