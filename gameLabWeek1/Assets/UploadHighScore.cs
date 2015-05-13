using UnityEngine;
using System.Collections;

public class UploadHighScore : MonoBehaviour {
	private bool Uploaded;
    public DbController dbController;

	void Awake()
	{
		Uploaded = false;
	}

	void OnCollisionEnter(Collision collision)
	{
		if(!Uploaded)
		{
            dbController.SaveScores(SystemInfo.deviceName, PlayerPrefs.GetInt("Player Score"));
		}
	}
}
