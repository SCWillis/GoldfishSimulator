using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePet : MonoBehaviour {



	[HideInInspector] public IPet currentState;
	[HideInInspector] public WanderState wanderState;
	[HideInInspector] public EatingState eatingState;
	[HideInInspector] public SleepState sleepState;
	[HideInInspector] public UnityEngine.AI.NavMeshAgent navMeshAgent;

	public Transform[] wanderPoints;



	void Awake(){
		
		wanderState = new WanderState (this);
		eatingState = new EatingState (this);
		sleepState = new SleepState (this);

		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}






	void Start () {
		
		currentState = wanderState;
	}
	

	void Update () {
	
		currentState.UpdateState ();

	}
}
