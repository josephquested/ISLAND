using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorInventory : MonoBehaviour {

	// WEAPON //

	public Weapon equippedWeapon;
	public Weapon secondaryWeapon;

	public Weapon defaultWeapon;

	public void EquipWeapon (Weapon weapon)
	{
		equippedWeapon = weapon;
		weapon.transform.parent = transform;
		weapon.AddToInventory();
	}

	public void ThrowWeapon ()
	{
		if (equippedWeapon != defaultWeapon)
		{
			equippedWeapon.RemoveFromInventory();
			equippedWeapon = defaultWeapon;
		}
	}

	public void ToggleEquipedWeapon ()
	{
		Weapon _equippedWeapon = equippedWeapon;
		Weapon _secondaryWeapon = equippedWeapon;
		equippedWeapon = _secondaryWeapon;
		secondaryWeapon = _equippedWeapon;
	}
}
