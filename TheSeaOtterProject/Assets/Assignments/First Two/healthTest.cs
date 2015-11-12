using UnityEngine;
using System.Collections;

public class healthTest : MonoBehaviour 
{
	int chickens = 0;
	// Use this for initialization
	void Start () 
	{
		chickens = addbyfiftyfive(chickens);
		Debug.Log (chickens);
	}
	int addbyfiftyfive (int recieve)
	{
		int grab;
		grab = recieve + 55;
		return grab;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
