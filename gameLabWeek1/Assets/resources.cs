using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class resources : MonoBehaviour {

	public 	int 	_score;
	private 	score 	_scoreUI;
	
	void Awake()
	{
		_scoreUI 	= 	gameObject.GetComponent<score>();
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
