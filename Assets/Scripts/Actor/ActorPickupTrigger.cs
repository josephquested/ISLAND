using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorPickupTrigger : MonoBehaviour {

	// TRIGGERS //

	public Item itemInTrigger;

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.GetComponent<Item>() != null)
		{
			itemInTrigger = collider.GetComponent<Item>();
		}
	}

	void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.GetComponent<Item>() != null)
		{
			itemInTrigger = null;
		}
	}
}
