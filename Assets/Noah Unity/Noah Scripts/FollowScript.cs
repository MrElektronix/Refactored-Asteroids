using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public Transform Player;
	public Transform Enemy;


	float RotatieSp = 3.0f;
	float MoveSpeed = 3.0f;
	public int AfstandAttack = 10;



	void Awake()
	{
		Enemy = transform;

	}


	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update()
	{
		float distance = (Player.position - Enemy.position).magnitude;
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation (Player.position - transform.position), RotatieSp * Time.deltaTime);
		transform.position += transform.forward * MoveSpeed * Time.deltaTime;
		if (distance <= AfstandAttack) {
			//werkt
			Debug.Log("werkt");



		}

	}









	


}
