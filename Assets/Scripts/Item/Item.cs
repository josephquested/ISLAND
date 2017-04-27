using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Weapon };

public class Item : MonoBehaviour {

	// SYSTEM //

	public ItemType itemType;

	// ITEM //

	public virtual void PickupToInventory (ActorInventory inventory)
	{
		// override //
	}

	public virtual void DropFromInventory (ActorInventory inventory)
	{
		// override //
	}
}
