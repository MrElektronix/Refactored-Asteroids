using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour {

	public int Ehp = 100;
	public int minHp = 0;
	public int HitPoints = 25;
	public int ScoreValue = 100;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Bullet")) {

			Destroy (other.gameObject);
			Ehp -= HitPoints;
			if(Ehp <= minHp){
				Destroy (gameObject);
				ScoreManager.score += ScoreValue;
			}

		}

	}
}
