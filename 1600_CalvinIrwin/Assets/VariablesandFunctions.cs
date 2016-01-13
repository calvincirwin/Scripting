using UnityEngine;
using System.Collections;

public class VariablesandFunctions : MonoBehaviour {

	// Use this for initialization
	int x = 10;
	int y= 7;
	string message = "Cho mama!";
	double deci = 1.5;

	void Start () {
		Debug.Log (message);
		Debug.Log (deci);
		Debug.Log("1 Times 2 Equals "+mult (1, 2));
		Debug.Log ("5 Times 6 Equals "+mult (5, 6));
		Debug.Log ("7 Times 5 Equals "+mult (7, 5));
		Debug.Log(x);
		x = mult(x,y);
		Debug.Log (x);
		x = 3;
		x = mult(x,y);
		Debug.Log (x);
		x = mult(x,4);
		Debug.Log (x);
	}
	
	int mult(int num1, int num2){
		int ret;
		ret = num1 * num2;
		return ret;
	}
}
