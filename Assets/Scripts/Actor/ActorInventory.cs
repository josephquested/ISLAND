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
				EquipWeapon(item.GetComponent<Weapon>());
				break;

			default:
				break;
		}
	}

	void EquipWeapon (Weapon weapon)
	{
		DropEquippedWeapon();
		equippedWeapon = weapon;
		weapon.PickupToInventory(this);
	}

	void DropEquippedWeapon ()
	{
		if (equippedWeapon != defaultWeapon)
		{
			equippedWeapon.DropFromInventory(this);
			equippedWeapon = null;
		}
		else
		{
			defaultWeapon.gameObject.SetActive(false);
			equippedWeapon = null;
		}
	}
}
