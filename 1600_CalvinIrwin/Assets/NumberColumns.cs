using UnityEngine;
using System.Collections;

public class NumberColumns : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] listA = {1,2,4,7,8,11,12,15,18,19,31,32,32,34,35};
		int[] listB = { 3, 5, 6, 9, 10, 13, 14, 16, 17, 20, 25, 27 };
		int[] listC = new int[listA.Length + listB.Length];
		int indexA;
		int indexB;
		int indexC;

		indexA = 0;
		indexB = 0;
		indexC = 0;

		while(indexA < listA.Length && indexB < listB.Length){
			if (listA[indexA] < listB[indexB]) {
				listC [indexC] = listA [indexA];
				indexC++;
				indexA++;
			} 
			else {
				listC [indexC] = listB [indexB];
				indexC++;
				indexB++;
			}
		}

		// Grab whatever is left in listB
		while (indexB < listB.Length) {
			listC [indexC] = listB [indexB];
			indexC++;
			indexB++;
		}


		// Grab whatever is left in listA
		while (indexA < listA.Length) {
			listC [indexC] = listA [indexA];
			indexA++;
			indexC++;
		}


		foreach (int n in listC) {
			print (n);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
