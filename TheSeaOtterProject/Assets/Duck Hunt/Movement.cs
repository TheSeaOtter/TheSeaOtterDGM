using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{

	public float moveSpeed = 15f;

	void Update ()
	{
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
	}
}