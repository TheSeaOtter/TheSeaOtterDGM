using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	public float vaultPopulation = 300.0f;
	public float highLimitPopulation = 200.0f;
	public float lowLimitPopulation = 50.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			PopulationTest();
		
		vaultPopulation -= Time.deltaTime * 10f;
	}
	
	
	void PopulationTest ()
	{

		if(vaultPopulation > highLimitPopulation)
		{

			print("Vault is full.");
		}

		else if(vaultPopulation < lowLimitPopulation)
		{

			print("Vault population decreasing.");
		}

		else
		{

			print("Vault is doing fine.");
		}
	}
}