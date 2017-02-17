using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : IPet {

	private readonly StatePet pet;
	private int nextWanderPoint;



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
		pet.navMeshAgent.destination = pet.wanderPoints [nextWanderPoint].position;
		pet.navMeshAgent.Resume ();

		if (pet.navMeshAgent.remainingDistance <= pet.navMeshAgent.stoppingDistance && !pet.navMeshAgent.pathPending) {
			nextWanderPoint = (nextWanderPoint + 1) % pet.wanderPoints.Length; // this allows for looping through the waypoints no matter the amount of waypoints.
		}
	}



}
