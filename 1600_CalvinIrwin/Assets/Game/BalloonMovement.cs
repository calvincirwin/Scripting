using UnityEngine;
using System.Collections;

public class BalloonMovement : MonoBehaviour 
{

	// Use this for initialization
	public Rigidbody balloonPrefab;
	public Transform balloonSpawn;
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Rigidbody balloonInstance;
			balloonInstance = Instantiate(balloonPrefab, balloonSpawn.position, balloonSpawn.rotation) as Rigidbody;
			balloonInstance.AddForce(balloonSpawn.up * 200);
		}
	}
}
