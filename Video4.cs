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

        

}
