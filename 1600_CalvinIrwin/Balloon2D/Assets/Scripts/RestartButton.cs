using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	public void RestartGame (){
		Application.LoadLevel (Application.loadedLevel);
	}

}
