using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public int z = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0f, 0f, z);
		Debug.Log (z);
		z--;
	}
}
