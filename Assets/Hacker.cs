using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    int level;
    string password;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;


	// Use this for initialization
	void Start () {
        ShowMainMenu("Hello user!");
	}
	
    void ShowMainMenu (string greeting = "") {
        currentScreen = Screen.MainMenu;
        // Clear the screen for the welcome text
        Terminal.ClearScreen();

        // Terminal greets user if variable isn't null
        if(greeting != "") {
            Terminal.WriteLine(greeting);
        }

        Terminal.WriteLine("Choose your target.");
        Terminal.WriteLine("1. Easy. You'll hack a library");
        //Empty line
        Terminal.WriteLine(" ");

        Terminal.WriteLine("2. Medium. You'll hack a police station");
        Terminal.WriteLine("3. Hard. You'll hack the Pentagon base");
    }


    void OnUserInput(string input)
    {
        if (input.ToLower() == "menu")
        {
            ShowMainMenu();
        }
        // If a player wants to clear the game screen
        else if (input.ToLower() == "clear")
        {
            Terminal.ClearScreen();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        switch (input.ToLower())
        {
            // Means the level
            case "1":
                level = 1;
                password = "book";
                StartGame();
                break;
            case "2":
                level = 2;
                password = "weapon";
                StartGame();
                break;
            case "3":
                level = 3;
                password = "goverment";
                StartGame();
                break;
            //Ester eggs
            case "telegram":
                Terminal.WriteLine("I'm sorry but that's impossible");
                break;
            case "ukraine":
                Terminal.WriteLine("The Europe");
                break;
            default:
                Terminal.WriteLine("Please, choose a valid level");
                break;
        }
    }

    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
    }

    void CheckPassword (string input) {
        if (input.ToLower() == password)
        {
            Terminal.WriteLine("WELL DONE!");
            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("Sorry, wrong password");
        }
	}
}
