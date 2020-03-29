using System.Collections;
using System.Collections.Generic;
using Systems.Linq; 
using UnityEngine;

public class Video5 : MonoBehaviour
{
	private string fullName = "Some Name"; 
    // Start is called before the first frame update
    void Start()
    {
    	//Delegate example
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

        messagesDel messagesWithLambda = (x) => {
        	x += " " + " in hierachy..."; 
        	Debug.Log(x);
        };

        FindGameObject("Video5", messagesWithLambda); 
        Debug.Log("FindGameObjectWithLambda(Video5)" + " " + FindGameObjectWithLambda("Video5")); 
        Debug.Log("Property FullName: " + FullName);


        //Linq Examples and lamdas
        List<Player> players = new List<Player> {
        	new Player("John", "Doe", 20, "johndoe@xbox.xom"),
        	new Player("Steve", "Doe", 20, "stevedoe@xbox.xom"),
        	new Player("Steve", "Doe", 40, "stevedoe@xbox.xom"),
        	new Player("Jason", "Doe", 50, "stevedoe@xbox.xom"),
        	new Player("Luis", "Toner", 60, "stevedoe@xbox.xom")
        };

        //linq
        List<Player> playersWithTheAgeOfTwenty = players.Where(p => p.Age == 20).ToList();
        int playersWithTheAgeOfTwentyCount = players.Count(p => p.Age == 20); 
        Debug.Log("playersWithTheAgeOfTwentyCount: " + playersWithTheAgeOfTwentyCount);

        Player playersWithTheAgeOfTwenty = players.FirstOrDefault(p => p.Age == 20); 
        Debug.Log("playersWithTheAgeOfTwentyCount: " + playersWithTheAgeOfTwenty.FirstName); 

        Player playerWithTheAgeOfTwentyLast = players.LastOrDefault(p => p.Age == 20);
        Debug.Log("playerWithTheAgeOfTwenty: "+ playerWithTheAgeOfTwentyLast.FirstName);
    }

public string FullName { get => fullName; set => fullName = value; }


private string FindGameObjectWithLambda(string name) => GameObject.Find(name).name;


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