using UnityEngine;
using System.Collections;

public class Class : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Student[] students = new Student[3];

		Student brian = new Student ("Brian", "123", 1);

		Student annie = new Student ();
		annie.name = "Annie";
		annie.phone = "456";
		annie.id = 2;

		students [0] = brian;
		students [1] = annie;
		students [2] = new Student ("Foster", "No num", 3);


		brian.PrintStudent (1);

		for (int indexS = 0; indexS < students.Length; indexS++) {
			students [indexS].PrintStudent (indexS + 1);
		}
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public class Student{
		public string name;
		public string phone;
		public int id;

		public Student() {
		}

		public Student(string name, string phone, int id) {
			this.name = name;
			this.phone = phone;
			this.id = id;
		}

		public void PrintStudent (int group){
			print ("I am Student #" + group + " - " + this.name  +" "+this.phone  +" id: " + this.id );
		}

	}
}
