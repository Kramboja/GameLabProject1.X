using UnityEngine;
using System.Collections;

public class InGameTimer : MonoBehaviour {

	private int time;

	void Awake()
	{
		if (time == 0)
		{
			time = 120;
		}

		InvokeRepeating("CountDown",1,1);
	}

	private void CountDown()
	{
		time -= 1;

		if(time == 0)
		{
			//game ends.
		}
	}
}