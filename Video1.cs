using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video1 : MonoBehaviour
{
    //int
    //decimal
    //float
    //string
    //object

    int age = 25;
    string fullName = "John Doe";
    decimal weight = 180.5M; //M stands for decimal type
    float position = 1000.00000002f;
    

    void Start()
    {
        PrintPersonInformation(100);
        Debug.Log(GetPersonAge());
        Debug.Log(GetFullNameLength()); 

    }


    void PrintPersonInformation()
    {
        var personAge = 3333;
        var personName = "John Doe 2";

        Debug.Log(personAge);
        Debug.Log(personName); 

        Debug.Log(age);
        Debug.Log(fullName);
        Debug.Log(weight);
        Debug.Log(position);

        age += 20;
        fullName = "John Toner";

        Debug.Log(age);
        Debug.Log(fullName);
    }


    void PrintPersonInformation(int newAge)
    {
        age = newAge;
        PrintPersonInformation(); 
    }


    int GetPersonAge()
    {
        int updating = 2000;
        age = updating;
        return age; 
    }

    int GetFullNameLength()
    {
        return fullName.Length; 
    }

}
