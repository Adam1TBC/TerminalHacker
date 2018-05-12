﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    int level;

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
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        switch (input.ToLower())
        {
            case "1":
                level = 1;
                StartGame();
                break;
            case "2":
                level = 2;
                StartGame();
                break;
            case "3":
                level = 3;
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

    // Update is called once per frame
    void Update () {
		
	}
}
