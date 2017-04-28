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

	void UpdateRotation ()
	{
		Vector3 dir = MousePosition.Get() - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
	}

}
