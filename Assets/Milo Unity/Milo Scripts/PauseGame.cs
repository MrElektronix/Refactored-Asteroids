using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	GameObject PauseScreen;

	public void Awake() {
		PauseScreen = GameObject.Find("Pause Omhulsel");
		PauseScreen.SetActive(false);
	}
		
	public void LoadPause() {
		PauseScreen.SetActive(true);
		Time.timeScale = 0;	
	}
}
