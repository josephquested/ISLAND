using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorInventory : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		pickupTrigger = GetComponentInChildren<ActorPickupTrigger>();
	}

	// INPUT //

	public void ReceivePickupThrowDown ()
	{
		ThrowWeapon();
		PickupWeapon();
	}

	public void ReceiveToggleWeaponDown ()
	{
		ToggleWeapon();
	}

	// WEAPON //

	ActorPickupTrigger pickupTrigger;

	public Weapon primaryWeapon;
	public Weapon secondaryWeapon;
	public Weapon defaultWeapon;

	void PickupWeapon ()
	{
		if (pickupTrigger.weaponInTrigger != null && !pickupTrigger.weaponInTrigger.inInventory)
		{
			Weapon weapon = pickupTrigger.weaponInTrigger;
			// pickupTrigger.weaponInTrigger = null;
			primaryWeapon = weapon;
			weapon.Pickup(this);
			weapon.Equip();
		}
	}

	public void ThrowWeapon ()
	{
		if (primaryWeapon != defaultWeapon)
		{
			primaryWeapon.Unequip();
			primaryWeapon.Throw();
			primaryWeapon = defaultWeapon;
		}
	}

	public void ToggleWeapon ()
	{
		primaryWeapon.Unequip();
		secondaryWeapon.Equip();
		Weapon _primaryWeapon = primaryWeapon;
		primaryWeapon = secondaryWeapon;
		secondaryWeapon = _primaryWeapon;
	}
}
