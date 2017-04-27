﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAttack : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		inventory = GetComponent<ActorInventory>();
	}

	void Update ()
	{
		UpdateAttack();
	}

	// ATTACK //

	ActorInventory inventory;

	bool attackDown;

	public void ReceiveInput (bool _attackDown)
	{
		attackDown = _attackDown;
	}

	void UpdateAttack ()
	{
		if (attackDown)
		{
			inventory.primaryWeapon.ReceiveInput();
		}
	}
}
