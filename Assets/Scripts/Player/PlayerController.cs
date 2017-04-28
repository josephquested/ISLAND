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
	}

	// MOVEMENT //

	ActorMovement movement;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		movement.ReceiveMovement(horizontal, vertical);
	}

	// ATTACK //

	ActorAttack attack;

	public void ReceiveAttackDown (bool attackDown)
	{
		if (attackDown)
		{
			attack.ReceiveAttackDown();
		}
	}

	// INVENTORY //

	ActorInventory inventory;

	public void ReceivePickupThrowDown (bool pickupThrowDown)
	{
		if (pickupThrowDown)
		{
			inventory.ReceivePickupThrowDown();
		}
	}

	public void ReceiveToggleWeaponDown (bool toggleWeaponDown)
	{
		if (toggleWeaponDown)
		{
			inventory.ReceiveToggleWeaponDown();
		}
	}
}
