using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingState : IPet {

	private readonly StatePet pet;



	public EatingState(StatePet statePet)
	{
		pet = statePet;
	}




	public void UpdateState()
	{
		//methods that defines states functions
	}




	public void ToWander()
	{
		pet.currentState = pet.wanderState;
	}




	public void ToEating()
	{
		Debug.Log ("Already in Eating state");
	}




	public void ToSleeping()
	{
		pet.currentState = pet.sleepState;	
	}


	public void OnEnter (Collider other)
	{
		Debug.Log ("Collision");
	}

}
