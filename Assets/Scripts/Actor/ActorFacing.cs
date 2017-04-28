using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorFacing : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update ()
	{
		UpdateFacing();
		UpdateSprite();
	}

	// FACING //

	bool facingLeft;

	public bool faceCursor;

	void UpdateFacing ()
	{
		if (faceCursor)
		{
			Vector2 mousePos = MousePosition.Get();
			facingLeft = mousePos.x < transform.position.x;
		}
	}

	// RENDERER //

	SpriteRenderer spriteRenderer;

	void UpdateSprite ()
	{
		spriteRenderer.flipX = facingLeft;
	}
}
