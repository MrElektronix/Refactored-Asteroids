using UnityEngine;
using System.Collections;



public class BulletSpawnerScript : MonoBehaviour {

	public GameObject bullet;
	public GameObject muzzle;
	public float bulletforce;
	public AudioClip shot;
	AudioSource audio;






	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Shoot ();
			audio.PlayOneShot (shot, 0.8f);


			

		}
	}

	public void Shoot() {
		GameObject TempBullet;
		TempBullet = Instantiate (bullet, muzzle.transform.position, muzzle.transform.rotation) as GameObject;
		Rigidbody TempRigidbody;
		TempRigidbody = TempBullet.GetComponent<Rigidbody> ();
		TempRigidbody.AddRelativeForce (Vector3.forward * bulletforce);
		Destroy (TempBullet, 20.0f);


	}



	

}


