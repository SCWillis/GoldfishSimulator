using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour {

	//public GameObject[] pets;

	public StatePet pet;

	public GUIStyle hungerStyle;
	public GUIStyle thirstStyle;
	public GUIStyle sleepStyle;

	public GameObject lettusBox;


	void Start () {
	
		lettusBox = GameObject.Find("LettusBox");
	
	}
	

	void Update () {
		
	}
		


	void OnGUI()
	{

		//STRUCTURES THE STATS BOX
		GUI.BeginGroup(new Rect(10,10,100,100));

		//hunger
		GUI.Box(new Rect(0, 0, 100, 20),"");
		GUI.Box(new Rect(0, 1, pet.hunger, 18),"Hunger", hungerStyle);

		//thirst
		GUI.Box(new Rect(0, 25, 100, 20),"");
		GUI.Box(new Rect(0, 26, pet.thirst, 18),"thirst",thirstStyle);

		//sleep
		GUI.Box(new Rect(0, 50, 100, 20),"");
		GUI.Box(new Rect(0, 51, pet.sleep, 18),"sleep",sleepStyle);

		GUI.EndGroup();
	}
}
