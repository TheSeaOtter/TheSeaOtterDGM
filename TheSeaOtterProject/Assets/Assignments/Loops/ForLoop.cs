using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
	int numCars = 5;
	
	
	void Start ()
	{
		for(int i = 0; i < numCars; i++)
		{
			Debug.Log("Creating Car number: " + i);
		}
	}
}