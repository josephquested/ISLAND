using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Weapon };

public class Item : MonoBehaviour {

	// SYSTEM //

	public ItemType itemType;

	void Start ()
	{

	}

	// ITEM //

	public bool inInventory;

	public void Pickup ()
	{
		print("pickup!");
	}

	public void Throw ()
	{

	}
}
