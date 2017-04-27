using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorInventory : MonoBehaviour {

	// INVENTORY //

	public Weapon equippedWeapon;
	public Weapon secondaryWeapon;

	public Weapon defaultWeapon;

	// PICKUP //

	public void Pickup (Item item)
	{
		switch (item.itemType)
		{
			case ItemType.Weapon:
				DropWeapon(equippedWeapon);
				PickupWeapon(item.GetComponent<Weapon>());
				break;

			default:
				break;
		}
	}

	void PickupWeapon (Weapon weapon)
	{
		equippedWeapon = weapon;
		weapon.PickupToInventory(this);
	}

	void DropWeapon (Weapon weapon)
	{
		if (equippedWeapon != defaultWeapon)
		{
			weapon.DropFromInventory(this);
		}
		else
		{
			defaultWeapon.gameObject.SetActive(false);
		}
		equippedWeapon = null;
	}
}
