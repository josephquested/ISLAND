using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	void Update ()
	{
		UpdateRotation();
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

	// ROTATION //

	Vector3 GetMousePosition ()
	{
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
		return Camera.main.ScreenToWorldPoint(mousePos);
	}

	void UpdateRotation ()
	{
		Vector3 dir = GetMousePosition() - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
	}

	// ANIMATION //

	Animator anim;

	void AnimateAttack ()
	{
		anim.SetTrigger("Attack");
	}
}
