using UnityEngine;
using System.Collections;

public class MoveToMenu : MonoBehaviour {

	public GameObject mainCamera;
	
	void OnTriggerEnter(Collider other)
	{
		mainCamera.GetComponent<ScreenMovement>().menu = true;
	}
}
