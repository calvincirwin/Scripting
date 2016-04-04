using UnityEngine;
using System.Collections;

public class SpikeController : MonoBehaviour {

	public Camera cam;
	private float maxWidth;

	// Use this for initialization
	void Start () {
		Vector3 screenSize = new Vector3 (Screen.width, Screen.height, 0);
		Vector3 worldSize = cam.ScreenToWorldPoint (screenSize);
		maxWidth = worldSize.x -0.25f;
	}

	// Update is called once per physics step
	void FixedUpdate () {
		Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
		Vector3 targetPosition = new Vector3 (rawPosition.x, 4, 0);
		if (targetPosition.x < -maxWidth) {
			targetPosition.x = -maxWidth;
		} else if (targetPosition.x > maxWidth) {
			targetPosition.x = maxWidth;
		}
		GetComponent<Rigidbody2D>().MovePosition (targetPosition);

	}
}
