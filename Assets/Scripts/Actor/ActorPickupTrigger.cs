using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorPickupTrigger : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{

	}

	// PICKUP //

	public void ReceiveInput ()
	{
		if (itemInTrigger != null)
		{
			itemInTrigger.Pickup();
		}
	}

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
