using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour {

	//GameObject MainMenu;
	//GameObject PauseScreen;


	public void Start() {
		//MainMenu = GameObject.Find("Main Menu Omhulsel");
		//PauseScreen = GameObject.Find("Pause Omhulsel");
	}

	public void LoadMain() {
		SceneManager.LoadScene (0);
		//MainMenu.SetActive(true);
		//PauseScreen.SetActive(false);
		//Time.timeScale = 0;
	}
}
