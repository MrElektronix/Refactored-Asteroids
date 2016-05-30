using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)//Als die in raking komt met een Bullet 
	{
		if (other.gameObject.tag == "Bullet") {
			Destroy (gameObject);
			}

		}
}
