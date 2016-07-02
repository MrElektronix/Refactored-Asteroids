using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public Transform Player;
	public Transform Enemy;

	float MoveSpeed = -9.0f;
	int AfstandAttack = 40;

	public GameObject Bullet;
	public float Bulletforce;
	private PlayerDeath playerDeath;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerDeath = Player.GetComponent<PlayerDeath> ();
		Example ();
	}

	void Update()
	{
		if (!Player) return;
		float distance = Vector3.Distance (transform.position, Player.transform.position);
		Vector3 direction = (transform.position - Player.position).normalized;
	
		if (distance <= AfstandAttack) {
			transform.position += (direction * 0) * 0;

		} else {

			transform.position += (direction * MoveSpeed) * Time.deltaTime;
		
		}
	}

	void Example() {
		InvokeRepeating ("Shoot", 9, 10f);
	}
		

	void Shoot()
	{
		//TempBullet.transform.position += (bulletdirection * Bulletforce ) * Time.deltaTime;
		//Destroy (TempBullet, 10.0f);
		if (!playerDeath) return;

		if (playerDeath.Dead) {
			CancelInvoke ();
			//Destroy (TempBullet);
		} else {
			GameObject TempBullet;
			TempBullet = Instantiate (Bullet,transform.position, transform.rotation) as GameObject;
			Rigidbody TempRigidbody;
			TempRigidbody = TempBullet.GetComponent<Rigidbody> ();
			Vector3 bulletdirection = (TempBullet.transform.position - Player.position).normalized;
			TempRigidbody.AddRelativeForce (bulletdirection * -Bulletforce);
		}




	}
}
