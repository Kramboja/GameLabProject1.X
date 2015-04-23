using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag != "plane" && collision.gameObject.tag != "enemy")
		{
			Destroy(gameObject);
		}
	}
}
