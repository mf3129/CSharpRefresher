using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //logical expressions
        // 1 == 1 (true)
        // 1 == 2 (false)


        int numberOne = 1;
        int numberTwo = 2;
        string nameOne = "J";
        string nameTwo = "Steve";
        bool isValid = false;


        //if statement
        if (numberOne == 1)
        {
            Debug.Log("This is true"); 
        } else
        {
            Debug.Log("This is false");
        }


        //if statement
        if (numberOne == numberTwo)
        {
            Debug.Log("This is true");
        }
        else if (numberOne == 1 && isValid)
        {
            Debug.Log("Yes the var numberOne == 1 is true"); 
        }
        else
        {
            Debug.Log("This is false");
        }



        isValid = numberOne == 1;

        Debug.Log("IsValid == " + isValid);

        Debug.Log("Check Equality: " + CheckValueEquality(1, 1));
        Debug.Log("Check Equality: " + CheckValueEquality(100, 200));


        // Or Operator

        //if statement
        if (numberOne == numberTwo || isValid)
        {
            Debug.Log("This is true");
        }


        if (nameOne.Length >= 2 && nameTwo.Length >= 3)
        {
            Debug.Log("Yes the var are the same and greater than 2 letters long");
        }
        else
        {
            Debug.Log("Yes the var are less than 2 letters long");
        }




    }



    bool CheckValueEquality(int value1, int value2)
    {
        return value1 == value2; 
    } 





   

}
