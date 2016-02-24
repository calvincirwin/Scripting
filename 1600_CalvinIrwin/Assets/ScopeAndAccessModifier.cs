using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifier : MonoBehaviour {

	// Use this for initialization
	public int alpha = 10;
	private int beta = 0;
	private int gamme = 5;
	void Example (int pens, int crayons){
		int answer;
		answer = pens * crayons * alpha;
		print (answer);
	}
	
	// Update is called once per frame
	void Update () {
		print ("Alpha is set to " + alpha);
	}
}
