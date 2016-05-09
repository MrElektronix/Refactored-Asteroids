using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GyroDisplay : MonoBehaviour {
	float xRot, yRot, zRot;
	public Text Gyro;

	void Update(){
		xRot = Input.acceleration.z * -180f;
		yRot = Input.acceleration.x * -180f;
		zRot = 0f;


		Gyro.text = "(x: " + xRot + " ," + "y: " + yRot + " ," + "z: " + zRot + ")";
	} 
}
