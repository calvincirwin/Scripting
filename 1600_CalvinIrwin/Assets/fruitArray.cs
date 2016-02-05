using UnityEngine;
using System.Collections;

public class fruitArray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int goodFruit = 0;
		int badFruit = 0;

		string[] fruits = {"Apples","Apples","Bananas","Pears","Grapes", "Kiwi"};

		foreach (string fruit in fruits) {
			if (fruit == "Bananas") {
				print ("Bananas Not Ripe");
				goodFruit = goodFruit + 1; 
			} else if (fruit == "Pears") {
				print ("yummy pears");
				goodFruit = goodFruit + 1; 
			} else if (fruit == "Apples") {
				print ("Green Apples");
				goodFruit = goodFruit + 1; 
			}
			else if (fruit == "Grapes"){
				print ("Seedless Grapes");
				goodFruit = goodFruit +1; 
			}
			else {
				print ("What is this?");
				badFruit = badFruit +1;
			}


		}
		print ("Good =" + goodFruit);
		print ("Bad =" + badFruit);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
