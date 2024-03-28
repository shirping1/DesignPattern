using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class WeaponSelector
{
    // �������̽� ����(������)
    private IWeapon iwp;

    public void SetWeapon(IWeapon weapon)
    {
        iwp = weapon;
    }

    public void Attack()
    {
        iwp.Attack();
    }
}
