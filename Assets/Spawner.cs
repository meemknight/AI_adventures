using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	// The prefab to spawn
	public GameObject prefab;

	// The maximum distance from the center that the prefab can be spawned
	public float maxDistance;

	// The interval at which to spawn the prefab
	public float interval;

	// A reference to the prefab's transform
	private Transform prefabTransform;

	void Start()
	{
		// Get a reference to the prefab's transform
		prefabTransform = prefab.transform;

		// Start spawning the prefab at the specified interval
		StartCoroutine(SpawnPrefab());
	}

	IEnumerator SpawnPrefab()
	{
		// Continuously spawn the prefab at the specified interval
		while (true)
		{
			// Wait for the specified interval
			yield return new WaitForSeconds(interval);

			// Generate a random position within the maximum distance from the center
			Vector2 randomPos = Random.insideUnitCircle * maxDistance;

			// Instantiate the prefab at the random position
			Instantiate(prefab, randomPos, prefabTransform.rotation);
		}
	}
}
