using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
	// The prefab for the bullet
	public GameObject bulletPrefab;

	// The speed at which the bullet will be shot
	public float bulletSpeed;

	// The time in seconds after which the bullet should despawn
	public float despawnTime;

	void Update()
	{
		// Check if the user has clicked the mouse button
		if (Input.GetMouseButtonDown(0))
		{
			// Create a new bullet at the position and rotation of this GameObject
			GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

			// Get a reference to the bullet's Rigidbody component
			Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

			// Add force to the bullet in the direction it is facing
			rb.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);

			// Start a coroutine that will despawn the bullet after the specified time
			StartCoroutine(DespawnBullet(bullet));
		}
	}

	IEnumerator DespawnBullet(GameObject bullet)
	{
		// Wait for the specified time
		yield return new WaitForSeconds(despawnTime);

		// Destroy the bullet
		Destroy(bullet);
	}
}
