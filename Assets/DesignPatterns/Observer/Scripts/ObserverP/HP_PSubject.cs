using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HP_PSubject : MonoBehaviour, PSubject
{
    private List<PObserver> m_PObservers = new List<PObserver>();

    private float m_HP;
    private float enemy_HP;

    private void Start()
    {
        m_HP = 100.0f;
        enemy_HP = 100.0f;

        var MHP = GameObject.Find("MyImage").GetComponent<PMyHpObserver>();
        var EHP = GameObject.Find("EnemyImage").GetComponent<PEnemyHpObserver>();

        Resgister(MHP);
        Resgister(EHP);

        Notify();

        //MHP.PObserverUpdate(m_HP, enemy_HP);
        //EHP.PObserverUpdate(m_HP, enemy_HP);
    }

    public void SetHP(float M_HP, float E_HP)
    {
        m_HP = M_HP;
        enemy_HP = E_HP;
        Notify();   
    }

    public void Notify()
    {
        foreach(var pokemon in m_PObservers)
        {
            pokemon.PObserverUpdate(m_HP, enemy_HP);
        }
    }


    public void Resgister(PObserver observer)
    {
        m_PObservers.Add(observer);
    }

    public void Remove(PObserver observer)
    {
        m_PObservers.Remove(observer);
    }

}
