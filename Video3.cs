using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video3 : MonoBehaviour
{
    // Start is called before the first frame update
    // loops
    void Start()
    {

        // for loop
        for(int i = 0; i <= 10 ; i++)
        {
            Debug.Log(i); 
        }

        // Array Structure in c#

        int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] peopleNames = new string[] { "John", "Max", "Sam", "Manny" };

        foreach(string name in peopleNames)
        {
            Debug.Log(name); 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
