using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab2;
	private float nextActionTime = 0.0f;
	public float period = 1.0f;

	// Update is called once per frame
	void Update()
	{

		if (Time.time > nextActionTime)
		{
			nextActionTime += period;
			Shoot();
		}
	}

	void Shoot()
	{
		Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
	}
}
