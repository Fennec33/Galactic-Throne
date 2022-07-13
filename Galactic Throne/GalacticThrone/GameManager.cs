using System.ComponentModel.Design;
using System.Xml;

namespace GalacticThrone;
using System;

public static class GameManager
{
    private static Empire _playerEmpire = new Empire();
    public static Empire PlayerEmpire { get; } = _playerEmpire;
    private static string _input = "";
    private static IInputHandler _currentState;
    private static EncounterSelector _encounterSelector;

    private static void Main()
    {
        StartGame();
        MainGameLoop();
    }

    private static void StartGame()
    {
        _encounterSelector = new EncounterSelector();
        _currentState = new MainMenu();
        _currentState.Open();
    }
    
    private static void MainGameLoop()
    {
        while (true)
        {
            _input = Screen.GetInput()!;
            _input = FormatInput(_input);

            if (_input == "quit")
                break;
            else if (_input == "help")
                ImagePrinter.Help();
            else
                _currentState.HandleInput(_input);
        }
    }

    private static void GoToMainMenu()
    {
        _currentState = new MainMenu();
        _currentState.Open();
    }
    
    public static void GoToEncounter()
    {
        _currentState = _encounterSelector.GetNextEncounter();
        _currentState.Open();
    }

    private static string FormatInput(string input)
    {
        input = input.Trim();
        input = input.ToLower();
        return input;
    }
}
                                                                                        
                                                                                        
                                                                                        
