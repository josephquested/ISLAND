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

	void Update ()
	{
		UpdateAttack();
		UpdatePickup();
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

	void UpdateAttack ()
	{
		controller.ReceiveAttack(Input.GetButtonDown("Attack"));
	}

	void UpdatePickup ()
	{
		controller.ReceivePickup(Input.GetButtonDown("Pickup"));
	}
}
