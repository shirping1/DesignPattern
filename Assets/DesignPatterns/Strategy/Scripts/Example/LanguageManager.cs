using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum LanguageType
{
    Korean, English
}

public class LanguageManager : MonoBehaviour
{
    public Text infoText;
    public Dropdown dropdown;
    ILanguage selectedLanguage;
    string setText;

    int playerLevel = 10;
    string playerName = "ȫ�浿";

    void Start()
    {
        ChangeLanguage(LanguageType.Korean);
    }

    private void ChangeLanguage(LanguageType languageType)
    {
        switch (languageType)
        {
            case LanguageType.Korean:
                selectedLanguage = new Korean();
                setText = selectedLanguage.SetText(playerName, playerLevel);
                break;
            case LanguageType.English:
                selectedLanguage = new English();
                setText = selectedLanguage.SetText(playerName, playerLevel);
                break;
        }
    }

    public void ChangeKorean()
    {
        ChangeLanguage(LanguageType.Korean);
    }

    public void ChangeEnglish()
    {
        ChangeLanguage(LanguageType.English);
    }

    public void OnclickSet()
    {
        infoText.text = setText;
    }

    public void ChangeValue()
    {
        ChangeLanguage((LanguageType)(dropdown.value));
    }

}
