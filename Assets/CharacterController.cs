using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public float speed = 5.0f;
	public GameObject player;

	void Update()
	{
		// Get input from the user
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		// Normalize the direction vector to avoid faster diagonal movement
		Vector3 direction = new Vector3(horizontalInput, verticalInput, 0).normalized;

		// Move the character based on the input
		player.transform.position = player.transform.position + direction * speed * Time.deltaTime;

		// Get the mouse position in screen space
		Vector3 mousePosition = Input.mousePosition;

		// Convert the mouse position from screen space to world space
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

		// Set the y and x coordinates of the mouse position to 0 to constrain the rotation to the z axis
		//mousePosition.y = 0;
		//mousePosition.x = 0;
		mousePosition.z = 0;

		// Rotate the player towards the mouse position on the z axis
		player.transform.LookAt(mousePosition, Vector3.forward);

		player.transform.eulerAngles = new Vector3(0, 0, player.transform.eulerAngles.z + 180);
	}
}
