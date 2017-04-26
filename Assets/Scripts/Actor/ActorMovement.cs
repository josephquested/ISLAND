using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	// MOVEMENT //

	Rigidbody2D rb;

	public float speed;

	public void ReceiveAxis (float horizontal, float vertical)
	{
		Move(GetMovementVector(horizontal, vertical));
		Animate(horizontal, vertical);
	}

	Vector2 GetMovementVector (float horizontal, float vertical)
	{
		return new Vector2(horizontal, vertical);
	}

	void Move (Vector2 movement)
	{
		rb.AddForce(movement * speed, ForceMode2D.Impulse);
	}

	// ANIMATOR //

	Animator anim;

	void Animate (float horizontal, float vertical)
	{
		anim.SetBool("Moving", horizontal != 0 || vertical != 0);
	}
}
