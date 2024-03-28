using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSubject : MonoBehaviour, Subject
{
    List<Observer> observers = new List<Observer>(); // ���������� �����ϴ� List

    private int number;

    public int GetNumber()
    {
        return number;
    }

    private void Start()
    {
        number = 10;

        var observer1 = new Observer1(gameObject);
        var observer2 = new Observer2(gameObject);

        Subscribe(observer1);
        Subscribe(observer2);
    }


    /// <summary>
    /// �������� �������鿡�� ������ �ϴ� ����� ���� �޼ҵ�
    /// </summary>
    public void Notify()
    {
        foreach (Observer observer in observers)
        {
            observer.OnNotify(number);
        }
    }

    public void Subscribe(Observer observer)
    {
        observers.Add(observer);
    }
    public void Unsubscribe(Observer observer)
    {
        // ���޹��� �������� �ε�����ȣ�� 0���� ũ�ٸ�
        if (observers.IndexOf(observer) > 0)
        {
            observers.Remove(observer);
        }
    }
}
