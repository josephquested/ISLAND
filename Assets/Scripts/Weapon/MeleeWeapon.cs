using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon {

	// ATTACK //

	public override void Attack ()
	{
		var _attackObject = Instantiate(attackObject, transform.position, transform.rotation);
		_attackObject.transform.parent = transform.parent;
		Destroy(_attackObject, 1f);
	}
}
