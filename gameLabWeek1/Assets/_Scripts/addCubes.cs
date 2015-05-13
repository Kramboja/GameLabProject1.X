using UnityEngine;
using System.Collections;

public class addCubes : MonoBehaviour {

	public GameObject block;
	
	private int blockCounter;
	private bool interactable;

	void Start()
	{
		interactable = true;
		addBlocks();
	}

	public void addBlocks()
	{
		if(interactable)
		{
			Instantiate(block,new Vector3(200f,10f,5f),Quaternion.identity);
			blockCounter++;
		}
		interactable = false;
		
		Invoke("handlingCheck",0.3f);
	}
	
	private void handlingCheck()
	{
		interactable = true;
	}

	void OnCollisionEnter(Collision collision)
	{
		addBlocks();
	}
}
