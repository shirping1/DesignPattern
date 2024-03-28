using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Arrow] Attack to Tartget");
    }

    public void Attack(GameObject obj)
    {
        Vector3 vector3 = new Vector3(transform.position.x, transform.position.y, 0);

        var bullet = Instantiate(obj);
        bullet.transform.position = vector3;
    }
}
