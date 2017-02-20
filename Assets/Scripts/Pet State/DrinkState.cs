using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkState : IPet {

	private readonly StatePet pet;
	private float drinkDistance = 5f;
	private float drinkRate = 0.25f;



	public DrinkState(StatePet statePet)
	{
		pet = statePet;
	}




	public void UpdateState()
	{
		MoveToDrink ();
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
		Debug.Log ("DrinkState");
	}


	public void ToSleeping()
	{
		pet.currentState = pet.sleepState;	
	}


	public void OnEnter (Collider other)
	{
		Debug.Log ("Collision");
	}


	//STATE SPECIFIC

	public void MoveToDrink()

	{
		pet.stateFlag.material.color = Color.blue;

		pet.navMeshAgent.destination = pet.waterBowl.position;

			//pet.navMeshAgent.Resume ();
			//if (pet.navMeshAgent.remainingDistance <= pet.navMeshAgent.stoppingDistance && !pet.navMeshAgent.pathPending) {

		if (pet.navMeshAgent.remainingDistance > drinkDistance) {
				pet.navMeshAgent.Resume ();
		}
		else
		{	//if(pet.navMeshAgent.remainingDistance <= 20f){
			pet.navMeshAgent.Stop ();
			pet.thirst += drinkRate;

			if (pet.thirst >= StatePet.MAXTHIRST) {
				pet.currentState = pet.wanderState;
			}
		}

	}




}
