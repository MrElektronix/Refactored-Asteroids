using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour {

	public int Ehp = 60;
	public int minHp = 0;
	public int HitPoints = 20;
	public int ScoreValue = 100;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("PlayerBullet")) {

			Destroy (other.gameObject);
			Ehp -= HitPoints;
			if(Ehp <= minHp){
				Destroy (gameObject);
				ScoreManager.score += ScoreValue;
				gameObject.GetComponent<Renderer>().material.color = Color.red;
			}

		}

	}
}
