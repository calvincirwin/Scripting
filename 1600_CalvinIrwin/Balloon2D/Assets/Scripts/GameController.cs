using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public Camera cam;
	public GameObject balloon;
	public float timeRemaining;
	public Text countDown;
	public GameObject gameOver;
	public GameObject restartButton;

 

	private float maxWidth;

	// Use this for initialization
	void Start () {
		Vector3 screenSize = new Vector3 (Screen.width, Screen.height, 0);
		Vector3 worldSize = cam.ScreenToWorldPoint (screenSize);
		float balloonWidth = balloon.GetComponent<Renderer> ().bounds.extents.x;
		maxWidth = worldSize.x - balloonWidth;
		StartCoroutine (Spawn ());
		UpdateText ();
	}
	void FixedUpdate (){
		timeRemaining -= Time.deltaTime;
		if (timeRemaining < 0) {
			timeRemaining = 0;
		}
		UpdateText ();
	}
	IEnumerator Spawn (){
		yield return new WaitForSeconds (1.0f);	
		while (timeRemaining>0) {
			float x = Random.Range (-maxWidth, maxWidth);
			float y = -6f;
			float z = 0f;
			Vector3 spawnPosition = new Vector3 (x, y, z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (balloon, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range (.5f, 1.50f));
		}
		yield return new WaitForSeconds(1f);
		gameOver.SetActive (true);
		yield return new WaitForSeconds (1f);
		restartButton.SetActive (true);


	}
	void UpdateText(){
		countDown.text = "Time Remains:\n" + Mathf.RoundToInt (timeRemaining);
	}
}
