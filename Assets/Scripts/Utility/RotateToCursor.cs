using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCursor : MonoBehaviour {

	// SYSTEM //

	void Update ()
	{
		UpdateRotation();
	}

	// ROTATION //

	Vector3 GetMousePosition ()
	{
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
		return Camera.main.ScreenToWorldPoint(mousePos);
	}

	void UpdateRotation ()
	{
		Vector3 dir = GetMousePosition() - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
	}

}
