using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour {

	//public GameObject[] pets;

	public StatePet pet;

	public GUIStyle hungerStyle;
	public GUIStyle thirstStyle;
	public GUIStyle sleepStyle;



	void Start () {


	}
	

	void Update () {
		
	}


	void OnGUI()
	{




		//STRUCTURES THE STATS BOX
		GUI.BeginGroup(new Rect(10,10,100,100));

		//hunger
		GUI.Box(new Rect(0, 0, 100, 20),"");
		GUI.Box(new Rect(0, 0, pet.hunger, 20),"Hunger", hungerStyle);

		//thirst
		GUI.Box(new Rect(0, 25, 100, 20),"");
		GUI.Box(new Rect(0, 25, pet.thirst, 20),"thirst",thirstStyle);

		//sleep
		GUI.Box(new Rect(0, 50, 100, 20),"");
		GUI.Box(new Rect(0, 50, pet.sleep, 20),"sleep",sleepStyle);

		GUI.EndGroup();
	}
}
