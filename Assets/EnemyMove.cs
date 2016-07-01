using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	Transform Player;
	float RotatieSp = 3.0f;
	float MoveSpeed = 3.0f;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update()
	{
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation (Player.position - transform.position), RotatieSp * Time.deltaTime);
		transform.position += transform.forward * MoveSpeed * Time.deltaTime;
	}












}

