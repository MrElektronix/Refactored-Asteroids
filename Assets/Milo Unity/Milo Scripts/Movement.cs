using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	// Use this for initialization
	public Vector3 z = new Vector3();
	void Start () {
		z = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
			transform.position = new Vector3(0f, 0f, z.z);
			z.z -= 0.1f;

	}
}
