using UnityEngine;
using System.Collections;

public class BulletSpawnerScript : MonoBehaviour {

	public GameObject bullet;
	public GameObject muzzle;
	public float bulletforce;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Shoot ();
		}
	}

	public void Shoot() {
		GameObject TempBullet;
		TempBullet = Instantiate (bullet, muzzle.transform.position, muzzle.transform.rotation) as GameObject;
		Rigidbody TempRigidbody;
		TempRigidbody = TempBullet.GetComponent<Rigidbody> ();
		TempRigidbody.AddRelativeForce (Vector3.forward * bulletforce);
		Destroy (TempBullet, 10.0f);
	}
}
