using UnityEngine;
using System.Collections;

public class moveToPlayer : MonoBehaviour {

	private float speed;

	void Awake()
	{
		speed = Random.Range(1,5);
	}

	void Update () 
	{
		transform.position = Vector3.MoveTowards(transform.position, new Vector2(0,0),speed * Time.deltaTime);
		if(transform.position.x < 1 && transform.position.x > -1)
		{
			if(transform.position.y < 1 && transform.position.y > -1)
			{
				Destroy(gameObject);
			}
		}
	}
}
