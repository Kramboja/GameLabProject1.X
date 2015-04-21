using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	public GameObject mainCamera;

	void Start()
	{
		//Debug.Log(MainCamera.GetComponent(ScreenMovement));//.GetComponent(ScreenMovement));
	}

	void OnTriggerEnter(Collider other)
	{




		Debug.Log(other);

		mainCamera.GetComponent<ScreenMovement>().moving = true;
	}

}
