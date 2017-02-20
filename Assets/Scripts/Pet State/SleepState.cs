using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepState : IPet {

	private readonly StatePet pet;
	private float sleepDistance = 0f;
	private float sleepRate = 0.25f;



	public SleepState(StatePet statePet)
	{
		pet = statePet;
	}




	public void UpdateState()
	{
		MoveToSleep ();
	}




	public void ToWander()
	{
		pet.currentState = pet.wanderState;
	}




	public void ToEating()
	{
		pet.currentState = pet.eatingState;
	}

	public void ToDrinking()
	{
		pet.currentState = pet.drinkState;
	}


	public void ToSleeping()
	{
		Debug.Log("Already in sleeping state");	
	}


	public void OnEnter (Collider other)
	{
		Debug.Log ("Collision");
	}



	public void MoveToSleep()
	{
		pet.stateFlag.material.color = Color.black;

		pet.navMeshAgent.destination = pet.bed.position;

		//pet.navMeshAgent.Resume ();
		//if (pet.navMeshAgent.remainingDistance <= pet.navMeshAgent.stoppingDistance && !pet.navMeshAgent.pathPending) {

		if (pet.navMeshAgent.remainingDistance > sleepDistance) {
			pet.navMeshAgent.Resume ();
		}
		else
		{	//if(pet.navMeshAgent.remainingDistance <= 20f){
			pet.navMeshAgent.Stop ();
			pet.sleep += sleepRate;

			//pet.transform.Rotate (0f, 1f, 0f);

			if (pet.sleep >= StatePet.MAXSLEEP) {
				pet.currentState = pet.wanderState;
			}
		}

	}




}
