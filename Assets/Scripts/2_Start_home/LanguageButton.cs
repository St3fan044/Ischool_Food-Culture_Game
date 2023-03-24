using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ButtonType
{
    LANGUAGE,
    GAMEMODE
}

public class LanguageButton : MonoBehaviour
{
    public bool selected;
    public LanguageButton otherLanguage;
    public Image sprite;
    public Color selectedColor;

    public ButtonType buttonType;

    public void ToggleLanguage()
    {
        if (selected == true) return;
        selected = true;

        if (selected == true)
        {
            otherLanguage.selected = false;
        }

        FindObjectOfType<ButtonPlay>();
    }

    private void Update()
    {
        sprite.color = selected == true ? Color.white : selectedColor;
    }
}
