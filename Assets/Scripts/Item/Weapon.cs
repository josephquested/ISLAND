using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		anim = GetComponent<Animator>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// INVENTORY //

	SpriteRenderer spriteRenderer;

	int primaryOrderInLayer = 5;
	int secondaryOrderInLayer = 3;

	public bool inInventory;

	public Vector3 equippedPosition;
	public Vector3 secondaryPosition;

	public void Pickup (ActorInventory inventory)
	{
		inInventory = true;
		transform.parent = inventory.transform;
	}

	public void Throw ()
	{
		inInventory = false;
		transform.parent = null;
	}

	public void Equip ()
	{
		gameObject.AddComponent<RotateToCursor>();
		spriteRenderer.sortingOrder = primaryOrderInLayer;
		transform.localPosition = equippedPosition;
	}

	public void Unequip ()
	{
		Destroy(GetComponent<RotateToCursor>());
		spriteRenderer.sortingOrder = secondaryOrderInLayer;
		transform.localPosition = secondaryPosition;
	}

	// ATTACK //

	public GameObject attackPrefab;
	public Transform attackSpawn;
	public bool inheritParentVelocity;

	bool attacking;

	public virtual void ReceiveAttackDown ()
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
