using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{
	void Start ()
	{
		bool shouldContinue = false;

		do
		{
			print ("Hello");

		}while(shouldContinue == true);
	}
}