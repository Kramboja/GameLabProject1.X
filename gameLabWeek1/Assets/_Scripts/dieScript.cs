using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

	public Material[] states;
	private int lives;

	public GameObject resources;
	public int minScore;
	public int maxScore;


	// Update is called once per frame
	void Awake () 
	{
		lives = 3;

		GetComponent<Renderer>().material = states[lives - 1];

		resources=GameObject.Find("Resources");
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag != "plane" && collision.gameObject.tag != "enemy")
		{
			Debug.Log(lives);

			if(lives < 0);
			{
				resources.GetComponent<resources>().UpdateScore(Random.Range(minScore,maxScore));

				Destroy(gameObject);
			}

			lives -= 1;

			GetComponent<Renderer>().material = states[lives - 1];
			GetComponent<AudioSource>().Play();
		}
	}
}
