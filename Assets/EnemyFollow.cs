using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
	// The speed at which the enemy should move
	public float speed = 2f;

	// The player game object
	private GameObject player;

	void Start()
	{
		// Get the player game object
		player = GameObject.FindWithTag("Player");
	}

	void Update()
	{
		// Get the direction to the player
		Vector3 direction = player.transform.position - transform.position;

		// Rotate the enemy to face the player on the z-axis
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, 0, angle + 90);

		// Normalize the direction to get a unit vector
		direction.Normalize();

		// Move the enemy in the direction of the player
		transform.position += direction * speed * Time.deltaTime;
	}
}
