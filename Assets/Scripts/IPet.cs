using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IPet
{
	void UpdateState();

	void ToWander();

	void ToEating();

	void ToSleeping();

}
