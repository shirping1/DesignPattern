using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������ ���� ���� enum
public enum WeaponType
{
    Bullet, Sword, Arrow
}

public class WeaponManager : MonoBehaviour
{
    public GameObject _bullet;
    public GameObject _sword;
    public GameObject _arrow;

    private GameObject selected_weapon;

    // ���� ���� ��� Ŭ������ �ʵ� ������ ����
    WeaponSelector weaponSelector;

    private IWeapon iwp;

    private void Start()
    {
        weaponSelector = new WeaponSelector();

        //weaponSelector.SetWeapon(new Bullet());
        ChangeWeapon(WeaponType.Bullet);
    }

    private void ChangeWeapon(WeaponType weaponType)
    {
        // ������Ʈ�� �پ��ִ� Iweapon ���� ������Ʈ�� ������ �� ���� �ı�

        var c = gameObject.GetComponent<IWeapon>() as Component;
        if (c != null)
        {
            Destroy(c);
        }

        // ���� ������ ���� ó��
        switch (weaponType)
        {
            case WeaponType.Bullet:
                iwp = gameObject.AddComponent<Bullet>();
                selected_weapon = _bullet;
                break;
            case WeaponType.Sword:
                iwp = gameObject.AddComponent<Sword>();
                selected_weapon = _sword;
                break;
            case WeaponType.Arrow:
                iwp = gameObject.AddComponent<Arrow>();
                selected_weapon = _arrow;
                break;
            default:
                iwp = gameObject.AddComponent<Bullet>();
                selected_weapon = _bullet;
                break;

        }
    }

    // ���� ���� Ŭ������ ��ɵ��� ���� �������̽��� ������ Ŭ������ ���� ������ ����
    public void ChangeBullet()
    {
        //weaponSelector.SetWeapon(new Bullet());
        ChangeWeapon(WeaponType.Bullet);
    }

    public void ChangeSword()
    {
        //weaponSelector.SetWeapon(new Sword());
        ChangeWeapon(WeaponType.Sword);
    }

    public void ChangeArrow()
    {
        //weaponSelector.SetWeapon(new Arrow());
        ChangeWeapon(WeaponType.Arrow);
    }

    public void OnFire()
    {
        //weaponSelector.Attack();
        iwp.Attack(selected_weapon);
    }

}
