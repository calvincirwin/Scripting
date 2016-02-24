using UnityEngine;
using System.Collections;

public class Car: MonoBehaviour{
	public CarMake make;
	public string model;
	private int myyear;
	public string color;

	public Car() {
	}
		
	public Car(CarMake make, string model, int year, string color) {

	

		this.make = make;
		this.model = model;
		this.myyear = year;
		this.color = color;

	}

	public int getYear(){
		return this.myyear;
	}

	public void PrintCar (int group){
		string whereMade;
//		if (this.make == CarMake.Hyundai) {
//			whereMade = "Korea";
//		} 
//		else if (this.make == CarMake.Chevy) {
//			whereMade = "USA";
//		} 
//		else if (this.make == CarMake.Dodge) {
//			whereMade = "USA";
//		} 
//		else {
//			whereMade = "Japan";
//		}

		switch (this.make) {
		case CarMake.Hyundai:
			whereMade = "Korea";
			break;
		case CarMake.Chevy:
			whereMade = "USA";
			break;
		case CarMake.Dodge:
			whereMade = "USA";
			break;
		default:
			whereMade = "Japan";
			break;
		}

		string needsInspection;
		if (this.myyear < 2009) {
			needsInspection = "Must Inspect";
		} else if (this.myyear == 2009) {
			needsInspection = "Please Inspect";
		}
		else {
			needsInspection = "No Inspection";
		}

		print ("This is Car #" + group + " - " + this.make +" " + this.model +" "+this.myyear 
			    + " "+this.color + " (" + whereMade  +") " + needsInspection);
	}

}