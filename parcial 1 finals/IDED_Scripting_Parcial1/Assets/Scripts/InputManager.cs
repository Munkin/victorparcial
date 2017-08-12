using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	[SerializeField]
	private GameController miGameController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKeyDown(KeyCode.A))
		{
			miGameController.ActiveBase.AttackWithCatapult();
		}

		if(Input.GetKeyDown(KeyCode.S))
		{
			miGameController.ActiveBase.AttackWithRay();
		}
	
	}
}
