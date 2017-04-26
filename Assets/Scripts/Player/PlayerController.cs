using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<ActorMovement>();
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
		movement.ReceiveAxis(horizontal, vertical);
	}
}
