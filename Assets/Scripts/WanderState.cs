using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : IPet {

	private readonly StatePet pet;

	//constructor
	public WanderState(StatePet statePet)
	{
		pet = statePet;
	}




	public void UpdateState()
	{
		Wander ();

	}




	public void ToWander()
	{
		Debug.Log("Already in wander state");
	}



		
	public void ToEating()
	{
		pet.currentState = pet.eatingState;
	}




	public void ToSleeping()
	{
		pet.currentState = pet.sleepState;	
	}


	void Wander()
	{

		pet.navMeshAgent.destination = pet.wPoints;
		pet.navMeshAgent.Resume ();

		if (pet.navMeshAgent.remainingDistance <= pet.navMeshAgent.stoppingDistance && !pet.navMeshAgent.pathPending) {
			
			pet.controller = new WPointController (pet).NextWayPoint ();
			Debug.Log("Target Reached");
			Debug.Log (pet.controller);
				
		}

	}



}
