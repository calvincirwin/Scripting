using UnityEngine;
using System.Collections;

public class MultiplyByTwo : MonoBehaviour {

	private int test;

	// Use this for initialization
	void Start () {
		int[] listA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		int[] listEven = new int[listA.Length];
		int[] listOdd = new int[listA.Length];

		int indexA = 0;
		int indexEven = 0;
		int indexOdd = 0;
		int testB = 20;
		test = 1;

		while (indexA < listA.Length) {
			if (evenNumber (listA [indexA])) {
				listEven[indexEven] = listA[indexA];
				indexEven++;
				indexA++;
			}
			else{
				listOdd[indexOdd] = listA[indexA];
				indexOdd++;
				indexA++;
			}
				
		}
			
		print ("*** Test = " + test);
		print ("*** Test B = " + testB);

		printList (listEven);
		printList (listOdd);

		print ("*** Test = " + test);
		print ("*** Test B = " + testB);
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	bool evenNumber(int n){
		test++;
		if (n / 2 * 2 == n) {
			return true;
		} 
		else {
			return false;
		}
	}

	void printList(int[] list){
		test++;
		int testB = 50;
		testB++;
		print ("foreach");
		foreach (int even in list) {
			print (even);
		}

		print ("While");
		int indexPrint = 0;
		while (indexPrint < list.Length){
			print (list [indexPrint]);
			indexPrint++;
		}

		print ("for");
		for(int indexP = 0;indexP < list.Length; indexP++){
			print (list [indexP]);			
		}
	}

}
