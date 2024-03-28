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
    GameObject HP_PSubject;

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        this.myHP = myHP;
        this.enemyHP = enemyHP;
        hpSlider.value = this.enemyHP;
    }

    public void OnClickAttack()
    {
        HP_PSubject.gameObject.GetComponent<HP_PSubject>().SetHP(myHP, enemyHP - damage);
    }
}
