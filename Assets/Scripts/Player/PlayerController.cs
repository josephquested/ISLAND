using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<ActorMovement>();
		attack = GetComponent<ActorAttack>();
		pickupTrigger = GetComponentInChildren<ActorPickupTrigger>();
	}

	void Update ()
	{
		UpdateAttack();
		UpdatePickup();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
	}

	// MOVEMENT //

	ActorMovement movement;

	float horizontal;
	float vertical;

	public void ReceiveAxis (float _horizontal, float _vertical)
	{
		horizontal = _horizontal;
		vertical = _vertical;
	}

	void UpdateMovement ()
	{
		movement.ReceiveInput(horizontal, vertical);
	}

	// ATTACK //

	ActorAttack attack;

	bool attackDown;

	public void ReceiveAttack (bool _attackDown)
	{
		attackDown = _attackDown;
	}

	void UpdateAttack ()
	{
		attack.ReceiveInput(attackDown);
	}

	// PICKUP //

	ActorPickupTrigger pickupTrigger;

	bool pickupDown;

	public void ReceivePickup (bool _pickupDown)
	{
		pickupDown = _pickupDown;
	}

	void UpdatePickup ()
	{
		if (pickupDown)
		{
			pickupTrigger.ReceiveInput();
		}
	}
}
