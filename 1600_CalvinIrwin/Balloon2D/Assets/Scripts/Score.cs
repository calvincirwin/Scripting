using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text score;
	public int scoreValue;
	public AudioSource sound;


	// Use this for initialization
	void Start () {
		scoreValue = 0;
		UpdateScore ();
	}
	void OnTriggerEnter2D (){
		sound.Play ();
		scoreValue = scoreValue + 1;
		UpdateScore ();
	}
	void UpdateScore (){
		score.text = "Score\n" + scoreValue;
		}
		

}
