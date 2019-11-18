using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video4 : MonoBehaviour
{
        // Creating a Human
        Debug.Log("Creating a human");
        // className variableName = new className();
        Human human1 = new Human("John", "Doe", 15);

        // Testing Properties
        Debug.Log(human1.FirstName);
        Debug.Log(human1.LastName);
        Debug.Log(human1.FullName);
        
        // Testing Methods
        Debug.Log("Is this human valid? " + human1.IsValid());
        Debug.Log("Is this human an adult? " + human1.IsAnAdult());
        Debug.Log("What is the length in characters of the full name? " + human1.FullNameSize());

        //Creating a new Monster

        Monster monster = new Monster();
        Debug.log("Monster information: " + monster);


        //Polymorphism

        //Using polymorphism to change from Monster class to player class
        Human fromMonsterToHuman = (Human)monster; //Casting a monster into it to a human.
	    Debug.log("Human Information From Monster information: " + fromMonsterToHuman);

        //Creating new player and using polymorphism
        Player player = new Player();

	    Human fromPlayerToHuman = (Human)player;
        Debug.Log("Human information from player " + fromPlayerToHuman);


        //Transforming from Human To Player
        //Player fromAHumanToAPlayer = (Player)human1;
        Player fromAHumanToAPlayer = new Player(human1.FirstName, human1.LastName, human1.Age,   //Setting the xbox one live page;
				human1.SetXboxOneLiveID(fromAHumanToAPlayer.Firstname +
                human1.lastName + "@xbox.com"););
	    
        Debug.Log("Player information from human " + fromAHumanToAPlayer);
}
