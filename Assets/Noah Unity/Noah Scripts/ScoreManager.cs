using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

	Text text;

	public static int score;

	void Awake(){
		text = GetComponent <Text>();
		score = 0;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score:" + score;
	}
}
