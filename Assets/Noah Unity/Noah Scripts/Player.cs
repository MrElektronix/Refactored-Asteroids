using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int P_hp = 100;



	// Use this for initialization
	void Start () {
		
	
	}
	void OnTriggerEnemy(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			Destroy (other.gameObject); //Destroy de enemy als die in aanraking komt met de player
			P_hp -= 25; //Haal 25 hp van de player af
			print (P_hp); //Print HP 
			}

		}



	}
		
			
	



	
