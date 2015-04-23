using UnityEngine;
using System.Collections;

public class moveToPlayer : MonoBehaviour {

	public float speed;

	void Awake()
	{
		speed = Random.Range(1,5);
	}

	void Update () 
	{
		transform.position = Vector3.MoveTowards(transform.position, new Vector2(0,0),speed * Time.deltaTime);
	}
}
