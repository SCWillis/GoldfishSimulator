using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingState : IPet {

	private readonly StatePet pet;
	private float eatDistance = 5f;
	private float eatRate = 0.25f;


	public EatingState(StatePet statePet)
	{
		pet = statePet;
	}


	public void UpdateState()
	{
		MoveToFood ();
	}


	public void ToWander()
	{
		pet.currentState = pet.wanderState;
	}


	public void ToEating()
	{
		Debug.Log ("Already in Eating state");
	}

	public void ToDrinking()
	{
		pet.currentState = pet.drinkState;
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


	public void MoveToFood()
	/*Moves the pet towards the food, stopping once it is eatDistance away from
	  the food, restoring the hunger value to 100 at a certain rate the switching 
	  state back to wander once its hunger has been restored to 100.*/
	{
		pet.stateFlag.material.color = Color.red;

		pet.navMeshAgent.destination = pet.foodBowl.position;

		//pet.navMeshAgent.Resume ();
		//if (pet.navMeshAgent.remainingDistance <= pet.navMeshAgent.stoppingDistance && !pet.navMeshAgent.pathPending) {
	
		if (pet.navMeshAgent.remainingDistance > eatDistance) {
			pet.navMeshAgent.Resume ();
		}
		else
		{	//if(pet.navMeshAgent.remainingDistance <= 20f){
			pet.navMeshAgent.Stop ();
			pet.hunger += eatRate;
	
			if (pet.hunger >= StatePet.MAXHUNGER) {
				pet.currentState = pet.wanderState;
			}
		}

	}




}
