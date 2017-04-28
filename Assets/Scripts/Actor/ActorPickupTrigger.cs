using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorPickupTrigger : MonoBehaviour {

	// TRIGGERS //

	public Weapon weaponInTrigger;

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.tag == "Weapon")
		{
			Weapon weapon = collider.GetComponent<Weapon>();
			if (!weapon.inInventory) { weaponInTrigger = weapon; }
		}
	}

	void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.tag == "Weapon")
		{
			Weapon weapon = collider.GetComponent<Weapon>();
			if (!weapon.inInventory) { weaponInTrigger = null; }
		}
	}
}
