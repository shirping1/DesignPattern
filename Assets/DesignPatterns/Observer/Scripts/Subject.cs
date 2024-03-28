using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���, ��ü�� �ǹ��ϴ� �������̽�
// �������� ���� ������ Ȱ�� ���õ� �ڵ���� ������ ����
public interface Subject
{
    void Subscribe(Observer observer);
    void Unsubscribe(Observer observer);
    void Notify();
}
