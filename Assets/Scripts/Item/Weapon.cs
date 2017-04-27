using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {

	// SYSTEM //

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	// PICKUP //

	public override void AddToInventory ()
	{
		GetComponent<RotateToCursor>().enabled = true;
		GetComponent<SpriteRenderer>().sortingOrder += 2;
		transform.localPosition = new Vector3(-0.15f, -0.15f, 0);
	}

	public override void RemoveFromInventory ()
	{
		GetComponent<RotateToCursor>().enabled = false;
		GetComponent<SpriteRenderer>().sortingOrder -= 2;
		transform.parent = null;
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
