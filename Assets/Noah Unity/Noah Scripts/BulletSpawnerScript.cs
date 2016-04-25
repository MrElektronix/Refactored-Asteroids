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
			GameObject TempBullet;
			TempBullet = Instantiate (bullet, muzzle.transform.position, muzzle.transform.rotation) as GameObject;
			TempBullet.transform.Rotate (Vector3.forward * 90);
			Rigidbody TempRigidbody;
			TempRigidbody = TempBullet.GetComponent<Rigidbody> ();
			TempRigidbody.AddForce (transform.forward * bulletforce);
			Destroy (TempBullet, 10.0f);


				


		}

	
	}
}
