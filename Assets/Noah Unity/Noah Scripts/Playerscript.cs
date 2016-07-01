using UnityEngine;
using System.Collections;

public class Playerscript : MonoBehaviour {

	public int Speed = 10;
	public int Health = 100;
	public int HitPoints = 25;


	// Use this for initialization
	void Start () {
	
	}
	
	// Deze code is alleen geschreven voor het testen van het volgen van de player 
	//Not in build
	void Update () {
		if(Input.GetKeyDown((KeyCode.UpArrow))){
			
			transform.Translate(Vector3.forward * Speed * Time.deltaTime);
		}
		if (Input.GetKeyDown ((KeyCode.DownArrow))) {
			transform.Translate (Vector3.back * Speed * Time.deltaTime);
		}
		if(Input.GetKeyDown ((KeyCode.RightArrow))){
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		}
		if (Input.GetKeyDown ((KeyCode.LeftArrow))) {
			transform.Translate (Vector3.left * Speed * Time.deltaTime);

		}

}

}