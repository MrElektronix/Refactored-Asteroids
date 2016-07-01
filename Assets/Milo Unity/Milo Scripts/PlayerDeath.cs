using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

	public int Php = 50;
	public int minHp = 0;	
	public int HitPoints = 5;
	public int ScoreValue = 100;
	public bool Dead = false;

	GameObject healthblock1;
	GameObject healthblock2;
	GameObject healthblock3;
	GameObject healthblock4;
	GameObject healthblock5;

	void Start() {
		healthblock1 = GameObject.Find("health1");
		healthblock2 = GameObject.Find("health2");
		healthblock3 = GameObject.Find("health3");
		healthblock4 = GameObject.Find("health4");
		healthblock5 = GameObject.Find("health5");
	}
	
		


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("EnemyBullet")) {

			Destroy (other.gameObject);
			Php -= HitPoints;
			if (Php == 40) {
				healthblock5.SetActive(false);
			}
			if (Php == 30) {
				healthblock4.SetActive(false);
			}
			if (Php == 20) {
				healthblock3.SetActive(false);
			}
			if (Php == 10) {
				healthblock2.SetActive(false);
			}
			if (Php == 0) {
				healthblock1.SetActive(false);
				SceneManager.LoadScene (2);
			}
			if(Php <= minHp){
				Destroy (gameObject);
				Dead = true;
				Debug.Log("player dead");
			}

		}

	}
}
