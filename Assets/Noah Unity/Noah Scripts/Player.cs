using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public float P_hp = 100f;
	public float curHealth = 0f;
	public int Death = 0;
	public GameObject bar;






	// Use this for initialization
	void Start () {
		curHealth = P_hp;

	
	
	}
	void OnTriggerEnemy(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			Destroy (other.gameObject); //Destroy de enemy als die in aanraking komt met de player
			P_hp -= 25; //Haal 25 hp van de player af
			print (P_hp); //Print HP 
			decreasehealth();

			}
		if(other.gameObject.tag == "Bullet")
		{
			P_hp -= 25;
			print (P_hp);
			decreasehealth ();


		}
	
	}
	public void decreasehealth()
	{
		curHealth -= 25f;
		float calcHealth = curHealth / P_hp;
		setHealth (calcHealth);

	}
	public void setHealth(float myHealth)
	{
		bar.transform.localScale = new Vector3 (myHealth,bar.transform.localScale.y,bar.transform.localScale.z);
	}


	void Update()
	{
		//if (P_hp <= Death)
		//{
		//Destroy (gameObject);
		//SceneManager.LoadScene (GameOverScreen);

	}
}

		
			
	



	
