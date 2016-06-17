using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	public int Health = 15;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)//Als die in raking komt met een Bullet 
	{
		if (other.gameObject.tag == "Bullet") {
			Player.P_hp += Health;
			Debug.Log (Player.P_hp);

			Destroy (gameObject);
			}

		}
}
