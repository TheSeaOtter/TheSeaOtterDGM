using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
	int bottlesInBucket = 3;

	void Start () 
	{
		while(bottlesInBucket > 0)
		{
			Debug.Log ("I picked up a bottle");
			bottlesInBucket--;
		}
	}
}