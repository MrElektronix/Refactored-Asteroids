using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	// Use this for initialization
	public Vector3 x = new Vector3();
	public Vector3 z = new Vector3();
	void Start () {
		x = transform.position;
		z = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.tag == "Enemy") {
			transform.position = new Vector3(x.x, 0f, z.z);
			z.z -= 0.1f;
		}
		else if (gameObject.tag == "Enemy2") {
			transform.position = new Vector3(x.x, 0f, z.z);
			x.x += 0.1f;
		}
	}
}
