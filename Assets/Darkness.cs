using UnityEngine;

public class Darkness : MonoBehaviour
{
	// The minimum darkness level
	public float minDarkness = 0.5f;

	// The maximum darkness level
	public float maxDarkness = 1.0f;

	// The radius within which the darkness level should be at the minimum
	public float radius = 10.0f;

	// Update is called once per frame
	void Update()
	{
		// Get the player's current position
		Vector3 playerPos = transform.position;

		// Calculate the distance from the player to the center
		float dist = Vector3.Distance(playerPos, Vector3.zero);

		// Calculate the darkness level based on the player's distance from the center
		float darkness = Mathf.Lerp(minDarkness, maxDarkness, dist / radius);

		// Set the darkness level for the whole scene
		RenderSettings.ambientLight = new Color(darkness, darkness, darkness);
	}
}
