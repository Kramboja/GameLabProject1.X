using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	public GameObject mainCamera;

	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other);

		mainCamera.GetComponent<ScreenMovement>().moving = true;
	}

}
