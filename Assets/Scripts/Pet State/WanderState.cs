using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : IPet {

	private readonly StatePet pet;
	private float maxWait = 15f;
	private float waitTime = Random.Range(0.1f, 15f);
	private float waitCount = 0f;

	//constructor
	public WanderState(StatePet statePet)
	{
		pet = statePet;
	}
		
	public void UpdateState()
	//Main loop
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


	//SPECIFIC TO STATE

	void Wander()
	{
		pet.navMeshAgent.destination = pet.wPoints;
		pet.navMeshAgent.Resume ();

		if (pet.navMeshAgent.remainingDistance <= pet.navMeshAgent.stoppingDistance && !pet.navMeshAgent.pathPending) {

			if (waitCount >= waitTime) {
				pet.controller = new WPointController (pet).NextWayPoint ();

				Debug.Log ("Target Reached");
				Debug.Log (pet.controller);

				waitCount = 0;
				waitTime = Random.Range (0.1f, maxWait);

			}else{
				
				waitCount += Time.deltaTime;
			}
		}
	}


	public void OnEnter (Collider other)
	{
		Debug.Log ("Collision");
	}






}
