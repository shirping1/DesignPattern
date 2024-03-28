using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 무기의 유형을 고르기 위한 enum
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

    // 무기 선택 기능 클래스를 필드 값으로 가짐
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
        // 오브젝트에 붙어있는 Iweapon 관련 컴포넌트를 조사해 그 값을 파괴

        var c = gameObject.GetComponent<IWeapon>() as Component;
        if (c != null)
        {
            Destroy(c);
        }

        // 무기 유형에 따라 처리
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

    // 무기 선택 클래스의 기능들을 통해 인터페이스로 구현한 클래스에 대한 설정을 변경
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
