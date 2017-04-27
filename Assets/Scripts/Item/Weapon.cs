using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		anim = GetComponent<Animator>();
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
