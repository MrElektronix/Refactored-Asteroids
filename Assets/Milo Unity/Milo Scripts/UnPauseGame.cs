﻿using UnityEngine;
using System.Collections;

public class UnPauseGame : MonoBehaviour {

	GameObject PauseScreen;

	public void Start() {
		PauseScreen = GameObject.Find("Pause Omhulsel");
	}

	public void LoadGameAgain() {
		PauseScreen.SetActive(false);
		Time.timeScale = 1;
	}
}
