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
			Vector2 mousePos = GetMousePosition();
			facingLeft = mousePos.x < transform.position.x;
		}
	}

	// RENDERER //

	SpriteRenderer spriteRenderer;

	void UpdateSprite ()
	{
		spriteRenderer.flipX = facingLeft;
	}

	// CURSOR //

	Vector2 GetMousePosition ()
	{
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
    return Camera.main.ScreenToWorldPoint(mousePos);
	}
}
