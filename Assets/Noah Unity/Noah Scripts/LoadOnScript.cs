using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnScript : MonoBehaviour {
	public string GameScene;


	public void LoadOnClick()
	{
		
		SceneManager.LoadScene (GameScene);
		
	}

}
