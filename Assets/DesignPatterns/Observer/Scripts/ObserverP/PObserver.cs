using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PObserver
{
    // ������ �����ϰ� �ʱ�ȭ �ϴ� ���
    // ������ ü�°� ���� ü���� �ۼ�
    void PObserverUpdate(float myHP, float enemyHP);
}
