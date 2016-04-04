using UnityEngine;
using System.Collections;

public class DestroyBalloon : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D balloon){
		Destroy (balloon.gameObject);
	}
}
