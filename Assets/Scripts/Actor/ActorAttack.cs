using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAttack : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		inventory = GetComponent<ActorInventory>();
	}

	// ATTACK //

	ActorInventory inventory;

	bool attackDown;

	public void ReceiveAttackDown ()
	{
		inventory.primaryWeapon.ReceiveAttackDown();
	}
}
