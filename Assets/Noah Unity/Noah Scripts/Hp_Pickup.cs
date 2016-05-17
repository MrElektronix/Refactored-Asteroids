using UnityEngine;
using System.Collections;

public class Hp_Pickup : MonoBehaviour {

	public int hp = 20;

	public int SpawnTime = 50;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Bullet")) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	int i = 0;
	int x = 0;

	// Update is called once per frame
	void Update () {
		i += 2;
		x += 2;


		transform.rotation = Quaternion.Euler (x, i, 0);
	}
}
