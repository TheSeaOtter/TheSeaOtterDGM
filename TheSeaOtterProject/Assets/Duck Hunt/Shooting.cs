using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour 
{
	public float bulletSpeed;
	public Rigidbody bulletPrefab;
	public Transform fireLocation;
	

	void Update () 
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bulletPrefab, fireLocation.position, fireLocation.rotation)as Rigidbody;
			bulletInstance.AddForce(fireLocation.forward * 5000);
		}
	}
}