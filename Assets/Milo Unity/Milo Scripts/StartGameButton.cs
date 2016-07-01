using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour {

	GameObject RemoveMainMenu;
	GameObject PauseScreen;

	public void Start() {
		RemoveMainMenu = GameObject.Find("Main Menu Omhulsel");
		PauseScreen = GameObject.Find("Pause Omhulsel");
	}

	public void LoadGameOnClick()
	{
		PauseScreen.SetActive(false);
		RemoveMainMenu.SetActive (false);
		Time.timeScale = 1;
	}
}
