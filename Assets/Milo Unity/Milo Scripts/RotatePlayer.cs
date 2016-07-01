using UnityEngine;
using System.Collections;

public class RotatePlayer : MonoBehaviour {

	private float gyroTimeout = 0f;
	private GyroCamera gyroCam;

	// Use this for initialization
	void Start () {
		gyroCam = Camera.main.GetComponent<GyroCamera> ();
		StartCoroutine ("GetTheYCalibration");
	}

	public void RotatePlayerYAxis()
	{
		float yAngle = gyroCam.GetYAngle ();

		/* think of this as rotating the camera base */
		this.transform.Rotate (new Vector3 (0f, 360f, yAngle));
	}

	IEnumerator GetTheYCalibration()
	{
		// provide some time for gyro initialization
		while (gyroTimeout > -30) {
			gyroTimeout -= Time.realtimeSinceStartup;
			yield return null;
		}

		RotatePlayerYAxis ();
	}
}
