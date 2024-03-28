using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class WeaponSelector
{
    // 인터페이스 접속(접근형)
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
