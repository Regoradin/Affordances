using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Endpoint : MonoBehaviour {

	public float rotation_speed;

	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("YOU WIN");
			if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)
			{
				Debug.Log("Loading next level");
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
			else
			{
				Debug.Log("Out of levels. Game Over");
				Application.Quit();
			}
		}
	}

	void Update () {

		//a nice little spin
		transform.Rotate(Vector3.up * rotation_speed, Space.World);

	}
}
