using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class English : ILanguage
{
    public string SetText(string name, int level)
    {
        string info = $"Language : English\n\nPlayer Name : {name}\nPlayer Level : {level}";
        return info;
    }
}
