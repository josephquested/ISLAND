using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorInventory : MonoBehaviour {

	// WEAPON //

	public Weapon primaryWeapon;
	public Weapon secondaryWeapon;
	public Weapon defaultWeapon;

	public void EquipWeapon (Weapon weapon)
	{
		weapon.AddToInventory(this);
		primaryWeapon = weapon;
	}

	public void ThrowWeapon ()
	{
		if (primaryWeapon != defaultWeapon)
		{
			primaryWeapon.RemoveFromInventory();
			primaryWeapon = defaultWeapon;
		}
	}

	public void ToggleWeapon ()
	{
		primaryWeapon.SetAsSecondary();
		secondaryWeapon.SetAsPrimary();

		Weapon _primaryWeapon = primaryWeapon;
		primaryWeapon = secondaryWeapon;
		secondaryWeapon = _primaryWeapon;
	}
}
