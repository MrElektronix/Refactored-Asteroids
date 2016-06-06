using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public Transform Player;
	public Transform Enemy;

	float MoveSpeed = -5.0f;
	int AfstandAttack = 50;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update()
	{
		float distance = Vector3.Distance (transform.position, Player.transform.position);
		Vector3 direction = (transform.position - Player.position).normalized;

		transform.position += (direction * MoveSpeed) * Time.deltaTime;
		Debug.Log (direction);
		if (distance <= AfstandAttack) {
			//Attack Functie 
			Debug.Log("shoot me");
		}

	}
}
