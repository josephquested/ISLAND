using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon {

	// ATTACK //

	public override void Attack ()
	{
		var _attackObject = Instantiate(attackPrefab, attackSpawn.position, attackSpawn.rotation);
		_attackObject.transform.parent = transform.parent;
		Destroy(_attackObject, 0.2f);
	}
}
