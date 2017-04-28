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
			weaponInTrigger = collider.GetComponent<Weapon>();
		}
	}

	void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.tag == "Weapon")
		{
			weaponInTrigger = null;
		}
	}
}
