using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {

	// SYSTEM //

	void Start ()
	{
		anim = GetComponent<Animator>();
		rotateToCursor = GetComponent<RotateToCursor>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// INVENTORY //

	RotateToCursor rotateToCursor;
	SpriteRenderer spriteRenderer;

	int primaryOrderInLayer = 5;
	int secondaryOrderInLayer = 3;

	public Vector3 equippedPosition;

	public override void AddToInventory (ActorInventory inventory)
	{
		transform.parent = inventory.transform;
		Equip();
	}

	public override void RemoveFromInventory ()
	{
		transform.parent = null;
		Unequip();
	}

	public void Equip ()
	{
		rotateToCursor.enabled = true;
		spriteRenderer.sortingOrder = primaryOrderInLayer;
		transform.localPosition = equippedPosition;
	}

	public void Unequip ()
	{
		rotateToCursor.enabled = false;
		spriteRenderer.sortingOrder = secondaryOrderInLayer;
	}

	public void SetAsPrimary ()
	{
		Equip();
	}

	public void SetAsSecondary ()
	{
		Unequip();
		transform.localPosition = Vector2.zero;
	}

	// ATTACK //

	public GameObject attackPrefab;
	public Transform attackSpawn;

	public bool attacking;
	public bool inheritParentVelocity;

	public virtual void ReceiveInput ()
	{
		if (!attacking)
		{
			Attack();
		}
	}

	public virtual void Attack ()
	{
		var attackObject = Instantiate(attackPrefab, attackSpawn.position, attackSpawn.rotation);
		AnimateAttack();

		if (inheritParentVelocity)
		{
			attackObject.GetComponent<Rigidbody2D>().velocity = GetComponentInParent<Rigidbody2D>().velocity;
		}
	}

	// ANIMATION //

	Animator anim;

	void AnimateAttack ()
	{
		anim.SetTrigger("Attack");
	}
}
