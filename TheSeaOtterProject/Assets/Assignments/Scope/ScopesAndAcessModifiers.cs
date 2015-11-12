using UnityEngine;
using System.Collections;

public class ScopesAndAcessModifiers : MonoBehaviour 
{
	public int alpha = 12;
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		alpha = 79;
		
		myOtherClass = new AnotherClass();
		myOtherClass.ItemBox(alpha, myOtherClass.ammo);
	}
	
	void Update ()
	{
		Debug.Log("Alpha is set to: " + alpha);
	}
}