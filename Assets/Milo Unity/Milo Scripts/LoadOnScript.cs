using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnScript : MonoBehaviour {

	public void LoadGameOnClick()
	{
		SceneManager.LoadScene (1);
	}

}
