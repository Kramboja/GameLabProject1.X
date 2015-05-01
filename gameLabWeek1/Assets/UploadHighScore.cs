using UnityEngine;
using System.Collections;

public class UploadHighScore : MonoBehaviour {
	private bool Uploaded;

	void Awake()
	{
		Uploaded = false;
	}

	void OnCollisionEnter(Collision collision)
	{
		if(!Uploaded)
		{
			//start uploading highscore here
		}
	}
}
