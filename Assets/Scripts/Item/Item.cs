using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Weapon };

public class Item : MonoBehaviour {

	// SYSTEM //

	public ItemType itemType;

	// ITEM //

	public virtual void AddToInventory ()
	{
		// override //
	}

	public virtual void RemoveFromInventory ()
	{
		// override //
	}
}
