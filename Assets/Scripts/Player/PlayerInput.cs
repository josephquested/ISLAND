using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// SYSTEM //

	PlayerController controller;

	void Start ()
	{
		controller = GetComponent<PlayerController>();
	}

	void FixedUpdate ()
	{
		UpdateAxis();
	}

	// INPUTS //

	void UpdateAxis ()
	{
		controller.ReceiveAxis(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}
}
