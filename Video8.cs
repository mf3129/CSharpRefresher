using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video8 : MonoBehaviour
{
	//[SerializeField]
	private GameMode gameMode = GameMode.Playing | GameMode.PlayerIdle;

	//private string gameModeString = "Pause"; 

    public enum GameMode
	{
        None = 0,
        Menu = 100,
        Pause = 2,
        Playing = 3,
        PlayerIdle = 4,
        GameOver = 50
	}

    void Update()
	{
		Debug.Log(gameMode);

        if(gameMode == (GameMode.Playing | GameMode.PlayerIdle))
		{
			Debug.Log("The currennt mode is set to " + GameMode.Playing.ToString() + " and " + GameMode.PlayerIdle.ToString()); 
		}

        Debug.Log("(int)GameMode.Menu: " + (int)GameMode.Menu);

		Debug.Log("(int)GameMode.GameOver: " + (int)GameMode.GameOver);

		Debug.Log(GameMode.Playing);
		Debug.Log(GameMode.GameOver.ToString());
	}

}
