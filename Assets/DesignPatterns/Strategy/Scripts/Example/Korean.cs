using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korean : ILanguage
{
    public string SetText(string name, int level)
    {
        string info = $"��� : �ѱ���\n\n�÷��̾� �̸� : {name}\n�÷��̾� ���� : {level}";
        return info;
    }
}
