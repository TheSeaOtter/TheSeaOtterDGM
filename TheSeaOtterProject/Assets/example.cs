using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	int health = 100;

	void Start () 
	{
		health = subtractbyten(health);
		Debug.Log (health);
	}
	int subtractbyten (int damage)
	{
		int hit;
		hit = damage - 10;
		return hit;
	}

	void Update () {
		
	}
}