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
		UpdateMovement();
	}

	void Update ()
	{
		UpdateAttack();
		UpdatePickupThrow();
		UpdateToggleWeapon();
	}

	// INPUTS //

	void UpdateMovement ()
	{
		controller.ReceiveMovement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}

	void UpdateAttack ()
	{
		controller.ReceiveAttackDown(Input.GetButtonDown("Attack"));
	}

	void UpdatePickupThrow ()
	{
		controller.ReceivePickupThrowDown(Input.GetButtonDown("Pickup/Throw"));
	}

	void UpdateToggleWeapon ()
	{
		controller.ReceiveToggleWeaponDown(Input.GetButtonDown("ToggleWeapon"));
	}
}
