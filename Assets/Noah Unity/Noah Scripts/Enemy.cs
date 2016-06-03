using UnityEngine;
using System.Collections;



public class Enemy : MonoBehaviour {

	public int Ehp = 100; //Health
	public int minHp = 0; //MinHealth
	public int HitPoints = 25; //Damage on enemy 
	public int Speed = 10; //Move Speed
	public int ScoreValue = 100; //Worth
	public AudioClip Collision;
	AudioSource audio;









	// Use this for initialization

	
	// Update is called once per frame
	void Update () {	
		//transform.Translate (Vector3.forward * Time.deltaTime);
		}

	void OnTriggerEnter(Collider other)//Als die in raking komt met een Bullet 
	{
		if (other.CompareTag("Bullet")) {
			Destroy (other.gameObject);//Destroy de bullet
			Ehp -= HitPoints;
			audio.PlayOneShot (Collision, 0.8f);
			if(Ehp < minHp){
			Destroy (gameObject);
			ScoreManager.score+= ScoreValue;
			}

		}

		
	}


}
