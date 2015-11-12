using UnityEngine;
using System.Collections;

public class conventionsandsyntaxpassoff : MonoBehaviour
{
	void Update ()
	{
		//This line tells me the x position of object
		Debug.Log (transform.position.y);

		if (transform.position.y <=10) 
		{
			Debug.Log ("I'm going to splater!");
		}
	}
}