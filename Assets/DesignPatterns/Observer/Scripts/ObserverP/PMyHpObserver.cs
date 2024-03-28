using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PMyHpObserver : MonoBehaviour, PObserver
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
        this.myHP = myHP;
        this.enemyHP = enemyHP;
        hpSlider.value = this.myHP;
    }

    public void OnClickAttack()
    {
        hP_PSubject.SetHP(myHP, enemyHP - damage);
    }
}
