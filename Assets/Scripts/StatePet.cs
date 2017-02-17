using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePet : MonoBehaviour {

	public Vector3 controller;
	public Vector3 wPoints;

	[HideInInspector] public IPet currentState;
	[HideInInspector] public WanderState wanderState;
	[HideInInspector] public EatingState eatingState;
	[HideInInspector] public SleepState sleepState;
	[HideInInspector] public UnityEngine.AI.NavMeshAgent navMeshAgent;

	//public Transform[] wanderPoints;


	void Awake(){

		controller = new WPointController(this).wayPoint;

		wanderState = new WanderState (this);
		eatingState = new EatingState (this);
		sleepState = new SleepState (this);

		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}


	void Start () {

		currentState = wanderState;
		wPoints = controller;
	}
	

	void Update () {

		currentState.UpdateState ();
		wPoints = controller;

	}
}
