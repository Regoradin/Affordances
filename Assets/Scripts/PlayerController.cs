using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float rotation_angle;

	private CharacterController controller;
	private GameObject body;

	void Start () {

		controller = GetComponent<CharacterController>();
		body = GameObject.Find("Body");

	}
	
	void Update () {

		//Handles player movement
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

		movement *= speed;
		movement += Physics.gravity;

		controller.Move(movement);

		//Rotates the player by rotation angle when the character is pressing movement keys
		Vector3 rotation = Vector3.zero;
		if (Input.GetAxis("Horizontal") > 0)
		{
			rotation.z = -rotation_angle;
		}
		if (Input.GetAxis("Horizontal") < 0)
		{
			rotation.z = rotation_angle;
		}
		if (Input.GetAxis("Vertical") > 0)
		{
			rotation.x = rotation_angle;
		}
		if (Input.GetAxis("Vertical") < 0)
		{
			rotation.x = -rotation_angle;
		}

		body.transform.localEulerAngles = rotation;
	
	}
}
