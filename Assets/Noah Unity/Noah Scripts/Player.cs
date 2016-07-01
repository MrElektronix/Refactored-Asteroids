using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public static int P_hp = 100;
	public int Death = 0;



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
		if(other.gameObject.tag == "Bullet")
		{
			P_hp -= 25;
			print (P_hp);


		}
	
	}
	void Update()
	{
		//if (P_hp <= Death)
		//{
		//Destroy (gameObject);
		//SceneManager.LoadScene (GameOverScreen);

	}
}

		
			
	



	
