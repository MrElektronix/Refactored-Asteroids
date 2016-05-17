using UnityEngine;
using System.Collections;



public class Enemy : MonoBehaviour {
	





	public int Health = 100;
	public int HitPoints = 25;
	public int Speed = 10;



	// Use this for initialization

	
	// Update is called once per frame
	void Update () {	
		//transform.Translate (Vector3.forward * Time.deltaTime);
		}

	void OnTriggerEnter(Collider other)//Als die in raking komt met een Bullet 
	{
		if (other.CompareTag("Bullet")) {
		
			Destroy (other.gameObject);//Destroy de bullet
			Destroy (gameObject);//Destroy de enemy
		}

		
	}

}
