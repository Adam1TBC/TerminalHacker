using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Terminal.WriteLine("Welcome to the Hacker game.");
        Terminal.WriteLine("Choose your difficult.");
        // For the empty line
        Terminal.WriteLine(" ");

        Terminal.WriteLine("1. Easy. You'll hack a library");
        Terminal.WriteLine(" ");

        Terminal.WriteLine("2. Medium. You'll hack a police station");
        Terminal.WriteLine("3. Hard. You'll hack the Pentagon base");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
