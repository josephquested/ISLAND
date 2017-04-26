﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAttack : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{

	}

	void Update ()
	{

	}

	// ATTACK //

	public Weapon weapon;

	bool attackDown;

	public void ReceiveInput (bool _attackDown)
	{
		attackDown = _attackDown;
	}

	void UpdateAttack ()
	{
		if (attackDown && !weapon.attacking)
		{
			print("attacking");
		}
	}
}