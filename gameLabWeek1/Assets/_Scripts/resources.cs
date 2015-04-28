using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class resources : MonoBehaviour {

	public int 	_score;
	private score 	_scoreUI;
	
	void Awake()
	{
		_scoreUI 	= 	gameObject.GetComponent<score>();

		if(PlayerPrefs.GetInt("Player Score") == null)
		{
			PlayerPrefs.SetInt("Player Score",0);
		}
		else
		{
			_score = PlayerPrefs.GetInt("Player Score");
		}
	}
	
	void Start()
	{

		_scoreUI.UpdateUI(_score);
	}
	
	public int score()
	{
		return _score;
	}
	
	public void SetScore(int amount)
	{
		_score = amount;
		_scoreUI.UpdateUI(_score);
	}
	
	public void UpdateScore(int amount)
	{
		_score += amount;
		_scoreUI.UpdateUI(_score);
	}
}