using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video1 : MonoBehaviour
{

    int age = 25;
    string fullName = "John Doe";
    decimal weight = 180.5M; //The M tells it is a decimal type
    float position = 1000.000002f;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        printPersonInformation(100);
        Debug.Log(GetPersonAge());
        Debug.Log("Get Person Length: " + GetFullNameLength());
    }

    void printPersonInformation() {
        
        var personAge = 30;
        var personName = "John Doe 2";
        
        Debug.Log(personAge);
        Debug.Log(personName);
        Debug.Log(age);
        Debug.Log(fullName);
        Debug.Log(weight);
        Debug.Log(position);
        
        age = 45;
        fullName = "John Toner";
        
        Debug.Log(age);
        Debug.Log(fullName);
    }
    
    void printPersonInformation(int newAge) {
        age = newAge;
        printPersonInformation();
    }
    
    int GetPersonAge() {
        return age;
    }
    
    int GetFullNameLength() {
        return fullName.Length;
    }
}
