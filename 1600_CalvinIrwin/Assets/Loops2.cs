using UnityEngine;
using System.Collections;

public class Loops2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int ndx = 0; ndx <10; ndx++) {
			print ("Hi");
		}

		string name;
		name = "Bob";
		string name2;
		name2 = "Jim";
		name = name2;
		name2 = "Mary";
		name2 = name;
		int[] job;
		job = new int[10];
		job [5] = 60;
		name = "Peter";
		job [1] = 7 + 3;
		job [1] = job [1] + 3;

		for (int ndx = 0; ndx <10; ndx++) {
			job [ndx] = (ndx + 1) * 10;
		}

		foreach (int index in job) {
			print (index);
		}
		int total = 0;
		for (int ndx = 0; ndx <10; ndx++){
			total = total + job [ndx];
		}
		print ("Total of all these numbers added up "+total);
		int mult = 1;
		for (int ndx = 0; ndx <10; ndx++) {
			mult = mult * job [ndx];
		}
		print ("Total of all of these Numbers Multiplied together. " + mult);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
