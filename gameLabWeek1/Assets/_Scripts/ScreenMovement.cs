using UnityEngine;
using System.Collections;

public class ScreenMovement : MonoBehaviour {

	private float _x;
	private float _y;

	public bool moving;
	public bool menu;

	void Awake()
	{
		Globals.GameState = "Menu";

		moving = false;
		menu = false;
		_x = 0;
		_y = 200;
	}

	void Update()
	{

		if(moving)
		{
			transform.position = new Vector3(_y - (_x*5)/2,((_x/5)*(_x/5))+ 2f,0);
			_x += 1f;

			if(_x >= 40f)
			{
				_x = -_x;
				_y = -2.5f;
			}

			if(_x == 0f)
			{
				_y = 0;
				moving = false;
				Globals.GameState = "Game";
			}
		}
		if (menu)
		{
			transform.position = new Vector3(_y + (_x*5)/2,((_x/5)*(_x/5))+ 2f,0);
			_x += 1f;
			
			if(_x >= 40f)
			{
				_x = -_x;
				_y = 2.5f;
			}
			
			if(_x == 0f)
			{
				menu = false;
				Globals.GameState = "Menu";
			}
		}
	}

	public void move()
	{
		moving = true;
	}
}
