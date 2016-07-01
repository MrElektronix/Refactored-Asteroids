using UnityEngine;
using System.Collections;

public class Blips : MonoBehaviour {
	public Transform Target;

	[SerializeField]
	MiniMap map;
	RectTransform myRectTransform;

	void Start() {
		map = GetComponentInParent<MiniMap> ();
		myRectTransform = GetComponent<RectTransform> ();
	}

	void LateUpdate() {
		Vector2 newPosition = map.TransformPosition (Target.position);
		myRectTransform.localPosition = newPosition;

	}
}
