using UnityEngine;
using System.Collections;


public class Button : MonoBehaviour {
	public GameObject bullet;
	public GameObject muzzle;
	public float bulletforce;

	public void OnTouchDown() {
		Debug.Log ("1");
		Shoot ();
	}

	public void Shoot() {
		GameObject TempBullet;
		TempBullet = Instantiate (bullet, muzzle.transform.position, muzzle.transform.rotation) as GameObject;
		Rigidbody TempRigidbody;
		TempRigidbody = TempBullet.GetComponent<Rigidbody> ();
		TempRigidbody.AddRelativeForce (Vector3.forward * bulletforce);
		//Destroy (TempBullet, 10f);
	}
}
