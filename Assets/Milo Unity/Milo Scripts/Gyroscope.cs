using UnityEngine;
using System.Collections;

public class Gyroscope : MonoBehaviour {
	float xRot, yRot, zRot;
	public float rotSpeed = 10f;

	void Update(){
		xRot = 0f;
		yRot = Input.acceleration.x * -180f;
		zRot = 0f;
		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (new Vector3 (xRot, yRot, zRot)), Time.deltaTime * rotSpeed);
	}
}
