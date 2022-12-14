using UnityEngine;

public class PlayerConstrainer : MonoBehaviour
{
	// The radius within which the player should be constrained
	public float radius = 10.0f;

	// Update is called once per frame
	void Update()
	{
		// Get the player's current position
		Vector3 playerPos = transform.position;

		// Calculate the distance from the player to the center
		float dist = Vector3.Distance(playerPos, Vector3.zero);

		float z = playerPos.z;
		// If the player is outside the allowed radius, move them back inside
		if (dist > radius)
		{
			// Calculate the direction from the player to the center
			Vector3 dir = playerPos.normalized;

			// Move the player towards the center, stopping when they reach the radius
			transform.position = dir * radius;
			transform.position = new Vector3(transform.position.x, transform.position.y,z);
		}
	}
}
