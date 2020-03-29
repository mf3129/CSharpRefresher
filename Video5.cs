using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	//Delegates example
    	// defining delegates and executing them
        del sumValuesDelegate = sumValues;

        Debug.Log(sumValuesDelegate(13,20));
        Debug.Log(sumValuesDelegate(100,200));
        Debug.Log(sumValuesDelegate(100,-90));


        del subtractValuesDelegate = subtractValues; 
		Debug.Log(subtractValuesDelegate(20,100));
        Debug.Log(subtractValuesDelegate(100,200));

        // call back example
        messagesDel messages = displayMessages; 
        FindGameObject("Video5", displayMessages); 


        // lambda examples

        // Lambda expressions are not limited to LINQ queries. 
        // You can use them anywhere a delegate value is expected, that is, 
        // wherever an anonymous method can be used.

    }


// Delegate is a pointer to a method
delegate int del(int x, int y); 

delegate void messagesDel(string messages); 

private void displayMessages(string messages) {
	Debug.Log(messages); 
}

// Methods
private int sumValues(int x, int y) {
	return x + y; 
}


private int subtractValues(int x, int y) {
	return x - y; 
}


private void FindGameObject(string name, messagesDel callback) {
	var foundGameObject = GameObject.Find(name); 
	if (foundGameObject == null) {
		callback("Unable to Find Game Object with name " + name);
	} else {
		callback("Found Game Object with name " + name);
	}
}

}