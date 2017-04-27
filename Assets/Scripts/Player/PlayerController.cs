using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<ActorMovement>();
		attack = GetComponent<ActorAttack>();
		inventory = GetComponent<ActorInventory>();
		pickupTrigger = GetComponentInChildren<ActorPickupTrigger>();
	}

	void Update ()
	{
		UpdateAttack();
		UpdateInteract();
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

	// INVENTORY //

	ActorInventory inventory;

	bool toggleWeapon;

	void ReceiveToggleWeapon (bool _toggleWeapon)
	{
		toggleWeapon = _toggleWeapon;
	}

	// INTERACT //

	ActorPickupTrigger pickupTrigger;

	bool interactDown;

	public void ReceiveInteract (bool _interactDown)
	{
		interactDown = _interactDown;
	}

	void UpdateInteract ()
	{
		if (interactDown)
		{
			inventory.ThrowWeapon();

			if (pickupTrigger.itemInTrigger != null)
			{
				if (pickupTrigger.itemInTrigger.itemType == ItemType.Weapon)
				{
					inventory.EquipWeapon(pickupTrigger.itemInTrigger.GetComponent<Weapon>());
				}
			}
		}
	}
}
