using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;

	void LateUpdate()
	{
		// Follow the player's position
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

		// Lock the camera's rotation to 0 degrees
		transform.rotation = Quaternion.Euler(0, 0, 0);
	}
}
