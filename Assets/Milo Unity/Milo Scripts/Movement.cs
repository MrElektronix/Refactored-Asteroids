using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	// Use this for initialization
	Vector3 z = new Vector3();
	void Start () {
		z = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3(transform.position.x, transform.position.y, z.z);
			z.z -= 0.1f;

	}
}
