using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour
{
	public int ammo;
	public int scrapmetal;
	public int nukacola;

	public void ItemBox (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Items total: " + answer);
	}
}