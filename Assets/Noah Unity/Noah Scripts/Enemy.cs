using UnityEngine;
using System.Collections;



public class Enemy : MonoBehaviour {

	public int Ehp = 100;
	public int minHp = 0;
	public int HitPoints = 25;
	public int Speed = 10;
	public int ScoreValue = 100;




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
			if(Ehp < minHp){
			Destroy (gameObject);
			ScoreManager.score += ScoreValue;
			

			}

		}

		
	}


}
