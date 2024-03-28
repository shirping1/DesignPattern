using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PEnemyHpObserver : MonoBehaviour, PObserver
{
    float myHP;
    float enemyHP;
    float damage = 10.0f;

    public Slider hpSlider;
    HP_PSubject hP_PSubject;

    private void Start()
    {
        hP_PSubject = GameObject.Find("HP_PSubject").GetComponent<HP_PSubject>();
    }

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        if(this.enemyHP != enemyHP && this.myHP == myHP)
        {
            this.enemyHP = enemyHP;
            AttackMessage();
        }
        else
        {
            this.enemyHP = enemyHP;
            this.myHP = myHP;
        }

        hpSlider.value = this.enemyHP;
    }

    public void AttackMessage()
    {
        Debug.Log($"이브이의 공격! Damage : {damage}");
        Invoke("AttackDamage", 1.0f);
    }
    public void AttackDamage()
    {
        hP_PSubject.SetHP(myHP - damage, enemyHP);
    }
}
