using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public Text scoreText;
	
	public void UpdateUI(int score)
	{
		scoreText.text = "" + score;
	}
}
