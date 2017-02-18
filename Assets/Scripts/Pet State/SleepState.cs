using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepState : IPet {

	private readonly StatePet pet;



	public SleepState(StatePet statePet)
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
		pet.currentState = pet.eatingState;
	}




	public void ToSleeping()
	{
		Debug.Log("Already in sleeping state");	
	}


	public void OnEnter (Collider other)
	{
		Debug.Log ("Collision");
	}



}
