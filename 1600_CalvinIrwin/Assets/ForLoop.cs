using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int goodFruit = 0;
		int badFruit = 0;

		string[] fruits = {"Apples","Apples","Bananas","Pears","Grapes", "Kiwi"};

		for (int ndx = 0; ndx <fruits.Length; ndx++) {
			if(fruits[ndx] == "Bananas"){
				print ("Bananas Not Ripe");
				goodFruit = goodFruit +1; 
			}
			else if(fruits[ndx] == "Pears"){
				print ("yummy pears");
				goodFruit = goodFruit +1; 
			}
			else if (fruits[ndx] == "Apples"){
				print ("Green Apples");
				goodFruit = goodFruit +1; 
			}
			else if (fruits[ndx] == "Grapes"){
				print ("Seedless Grapes");
				goodFruit = goodFruit +1; 
			}
			else {
				print ("What is this?");
				badFruit = badFruit +1;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}