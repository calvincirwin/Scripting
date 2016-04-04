using UnityEngine;
using System.Collections;

public class BalloonMovement : MonoBehaviour 
{

	// Use this for initialization
	public Rigidbody balloonPrefab;
	public Transform balloonSpawn;
	public int balloonNumber;
	void Start () 
	{
		
	}

	void OnTriggerEnter (Collider Spawn)
	{
		if (Spawn.transform.tag == "balloonTrigger") {
			Debug.Log ("balloonTrigger");
			Rigidbody balloonInstance;
			balloonInstance = Instantiate(balloonPrefab, balloonSpawn.position, balloonSpawn.rotation) as Rigidbody;
			balloonInstance.AddForce(balloonSpawn.up * 200);
		}
	}
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			int launchNum = Random.Range (1, 5);
			if (launchNum == balloonNumber) {
				Rigidbody balloonInstance;
				balloonInstance = Instantiate (balloonPrefab, balloonSpawn.position, balloonSpawn.rotation) as Rigidbody;
				balloonInstance.AddForce (balloonSpawn.up * (200 + 20*(balloonNumber-1)));
			}
		}
	}



}
