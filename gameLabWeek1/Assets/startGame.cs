using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other);
	}

}
