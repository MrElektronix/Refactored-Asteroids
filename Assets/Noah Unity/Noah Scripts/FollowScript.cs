using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public Transform Player;
	public Transform Enemy;


	float RotatieSp = 3.0f;
	float MoveSpeed = 3.0f;
	public int AfstandAttack = 10;

	public GameObject Muzzle;
	public GameObject Bullet;
	public float Bulletforce;




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
			Shoot();
			Debug.Log("werkt");
		}

	}
	void Shoot()
	{
		GameObject TempBullet;
		TempBullet = Instantiate (Bullet, Muzzle.transform.position, Muzzle.transform.rotation) as GameObject;
		Rigidbody TempRigidbody;
		TempRigidbody = TempBullet.GetComponent<Rigidbody> ();
		TempRigidbody.AddRelativeForce (Vector3.forward * Bulletforce);
		Destroy (TempBullet, 20.0f);

	}










	


}
