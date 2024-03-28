using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korean : ILanguage
{
    public string SetText(string name, int level)
    {
        string info = $"언어 : 한국어\n\n플레이어 이름 : {name}\n플레이어 레벨 : {level}";
        return info;
    }
}
