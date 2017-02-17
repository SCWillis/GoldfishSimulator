using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPointController {

	private readonly StatePet pet;
	public Vector3 wayPoint = new Vector3(10f,1f,10f);



	public WPointController(StatePet statePet){
		pet = statePet;
	}


	public Vector3 NextWayPoint() {

		return wayPoint = new Vector3 (Random.Range (-20f, 20f), 1f, Random.Range (-20f, 20f));

	}
}
