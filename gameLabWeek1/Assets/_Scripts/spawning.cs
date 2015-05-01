using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawning : MonoBehaviour {

	public GameObject[] enemies;
	public GameObject endScreen;

	private int waveSize;
	private bool inGame;

	private Text wave;


	void Awake()
	{
		inGame = true;
		wave = GameObject.Find("waveNumber").GetComponent<Text>();
		endScreen = GameObject.Find("EndScreen");
		endScreen.SetActive(false);
		startSpawnEnemies(30);
	}

	void spawnEnemies()
	{
		var enemy = Instantiate(enemies[Random.Range(0, enemies.Length-1)]);
		int x = Random.Range(-45,45);
		int y = Random.Range(-45,-35);

		wave.text = "" + waveSize + "/30";

		if(x <= -35|| x >= 35)
		{
			y = Random.Range(-45,45);
		}
		else if(y >= -40)
		{
			y = Random.Range(40,45);
		}

		enemy.transform.position = new Vector3(x,10,y);

		waveSize -= 1;

		if(waveSize < 0)
		{
			waveSize = 30;
			CancelInvoke("spawnEnemies");
			InvokeRepeating("countDown",1,1);
		}
	}

	private void countDown()
	{
		if(inGame)
		{
			waveSize = 10;
			inGame = false;
		}
		wave.text = "" + waveSize;
		waveSize -= 1;

		if (waveSize < 0)
		{
			CancelInvoke("countDown");
			endScreen.SetActive(true);
		}
	}
	public void startSpawnEnemies(int size)
	{
		waveSize = size;
		InvokeRepeating("spawnEnemies",1,2);
	}
}
