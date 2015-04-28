using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawning : MonoBehaviour {

	public GameObject[] enemies;
	private int waveSize;

	private Text wave;


	void Awake()
	{
		wave = GameObject.Find("waveNumber").GetComponent<Text>();
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

		if(waveSize == 0)
		{

		}

		waveSize -= 1;

		if(waveSize == 0)
		{
			waveSize = 30;
			CancelInvoke("spawnEnemies");
		}
	}

	public void startSpawnEnemies(int size)
	{
		waveSize = size;
		InvokeRepeating("spawnEnemies",1,3);
	}
}
