using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PSubject
{
    void Resgister(PObserver observer);
    void Remove(PObserver observer);
    void Notify();
}
