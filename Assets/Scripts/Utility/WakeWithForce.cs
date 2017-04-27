using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeWithForce : MonoBehaviour {

	// SYSTEM //

	public float force;

	void Start ()
	{
		GetComponent<Rigidbody2D>().AddForce(-transform.up * force, ForceMode2D.Impulse);
	}
}
