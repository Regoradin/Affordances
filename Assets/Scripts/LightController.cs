using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	private Light lightbulb;
	private Vector3 endpoint_position;
	private GameObject floor;

	void Start () {

		lightbulb = GetComponent<Light>();

		//looks for an object called "Endpoint" for the  position. If it doesn't exist, sets the position equal to 0
		if (GameObject.Find("Endpoint"))
		{
			endpoint_position = GameObject.Find("Endpoint").transform.position;
		}
		else
		{
			endpoint_position = Vector3.zero;
		}

		//looks for the floor, if not logs an error before an inevitable crash
		floor = GameObject.Find("Floor");

	}
	
	void Update () {

		//changes the intesity of the light with the distance between the player and the endpoint as compared with the size of the level, which is the scale of the floor in the x direction for now
		float intensity = floor.transform.localScale.x/(Vector3.Distance(endpoint_position, transform.parent.transform.position));

		lightbulb.intensity = intensity;

	}
}
