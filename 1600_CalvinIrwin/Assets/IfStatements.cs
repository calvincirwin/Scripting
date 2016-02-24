using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	public float cokeTemp = 100.0f;
	public float cokeJustRight = 50.0f;
	public float cokeSlush = 32.0f;

	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		cokeTemp -= Time.deltaTime * 10f;
	}
	
	
	void TemperatureTest ()
	{
		// If the coffee's temperature is greater than the hottest drinking temperature...
		if(cokeTemp > cokeJustRight)
		{
			// ... do this.
			print("This Coca-Cola is room temperature. Yuck!");
		}
		// If it isn't, but the coffee temperature is less than the coldest drinking temperature...
		else if(cokeTemp < cokeSlush)
		{
			// ... do this.
			print("This Coca-Cola is a little bit too cold. I hope you like Slurpees...");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("Your Coca-Cola is a nice cold refrigerated beverage. Refreshing.");
		}
	}
}