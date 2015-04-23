using UnityEngine;
using System.Collections;

public class GameScreen : MonoBehaviour {

	public GameObject spawner;
	private bool spawnerPlaced;

	void Update () 
	{
		if(Globals.GameState == "Game" && !spawnerPlaced)
		{
			Instantiate(spawner);
			spawnerPlaced = true;
		}
	}
}
