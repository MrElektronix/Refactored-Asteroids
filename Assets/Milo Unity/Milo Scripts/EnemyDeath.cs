using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour {

	public int Ehp = 60;
	public int minHp = 0;
	public int HitPoints = 30;
	public int ScoreValue = 100;
	GameObject HealthBar1;
	GameObject playerbullet;


	public void Start() {
		HealthBar1 = GameObject.Find("enemy_healthbar1");
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("PlayerBullet")) {

			Destroy (other.gameObject);
			Ehp -= HitPoints;
			HealthBar1.gameObject.transform.localScale -= new Vector3(20,0,0);
			if(Ehp <= minHp){
				Destroy (gameObject);
				ScoreManager.score += ScoreValue;
			}

		}

	}
}
