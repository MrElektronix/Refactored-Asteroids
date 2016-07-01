using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

	public int Php = 50;
	public int minHp = 0;
	public int HitPoints = 10;
	public int ScoreValue = 100;
	public bool Dead = false;

	void Awake() {
		UnityEngine.GameObject healthblock1 = GameObject.Find("health1");
		UnityEngine.GameObject healthblock2 = GameObject.Find("health2");
		UnityEngine.GameObject healthblock3 = GameObject.Find("health3");
		UnityEngine.GameObject healthblock4 = GameObject.Find("health4");
		UnityEngine.GameObject healthblock5 = GameObject.Find("health5");
	}
		


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("EnemyBullet")) {

			Destroy (other.gameObject);
			Php -= HitPoints;
			if (Php == 40) {
//				healthblock5.SetActive(false);
			}
			if(Php <= minHp){
				Destroy (gameObject);
				Dead = true;
				Debug.Log("player dead");
			}

		}

	}
}
