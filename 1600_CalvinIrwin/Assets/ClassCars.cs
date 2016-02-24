using UnityEngine;
using System.Collections;

public class ClassCars : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Car[] cars = new Car[6];

		Car sonata = new Car (CarMake., "Sonata", 2010, "Red");
		Car civic = new Car (CarMake.Honda, "Civic", 2004, "Gold");
		Car malibu = new Car (CarMake.Chevy, "Malibu", 2008, "Silver");
		Car focus = new Car (CarMake.Ford, "Focus", 2011, "White");
		Car charger = new Car (CarMake.Dodge, "Charger", 2013, "Black");
		Car maxima = new Car (CarMake.Nisaan, "Maxima", 2000, "White");



		cars [0] = sonata;
		cars [1] = civic;
		cars [2] = malibu;
		cars [3] = focus;
		cars [4] = charger;
		cars [5] = maxima;


		civic.PrintCar (1);

		for (int indexS = 0; indexS < cars.Length; indexS++) {
			if (cars [indexS].getYear() >= 2010){
				cars [indexS].PrintCar (indexS + 1);	
			}

		}

	}

	// Update is called once per frame
	void Update () {

	}
}