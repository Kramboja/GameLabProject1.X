using UnityEngine;
using System.Collections;

public class spawning : MonoBehaviour {

	public GameObject[] enemies;

	void Awake()
	{
		Debug.Log(Random.Range(0,enemies.Length));

		InvokeRepeating("spawnEnemies",1,1);
	}

	void spawnEnemies()
	{
		var enemy = Instantiate(enemies[Random.Range(0, enemies.Length-1)]);
		int x = Random.Range(-45,45);
		int y = Random.Range(-45,-35);

		if(x <= -35|| x >= 35)
		{
			y = Random.Range(-45,45);
		}
		else if(y >= -40)
		{
			y = Random.Range(40,45);
		}

		enemy.transform.position = new Vector3(x,10,y);
	}
}
