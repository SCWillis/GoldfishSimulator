using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePet : MonoBehaviour {

	public Vector3 controller;
	public Vector3 wPoints;

	//params for hunger
	public float hunger = 100f;
	public const float MAXHUNGER = 100f;
	public Transform foodBowl;

	//params for thirst
	public float thirst = 100f;
	public const float MAXTHIRST = 100f;
	public Transform waterBowl;


	//params for sleeping
	public float sleep = 100f;
	public const float MAXSLEEP = 100f;
	public Transform bed;


	public MeshRenderer stateFlag;

	[HideInInspector] public IPet currentState;
	[HideInInspector] public WanderState wanderState;
	[HideInInspector] public EatingState eatingState;
	[HideInInspector] public SleepState sleepState;
	[HideInInspector] public DrinkState drinkState;
	[HideInInspector] public UnityEngine.AI.NavMeshAgent navMeshAgent;

	//public Transform[] wanderPoints;


	void Awake(){

		controller = new WPointController(this).wayPoint;
		wanderState = new WanderState (this);
		eatingState = new EatingState (this);
		drinkState = new DrinkState (this);
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

	private void OnTriggerEnter(Collider other)
	{
		currentState.OnEnter (other);
	}
}
