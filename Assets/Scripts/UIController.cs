using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour

{
    public Sprite MusicOnSprite;
    public Sprite MusicOffSprite;
    public Sprite SFXOnSprite;
    public Sprite SFXOffSprite;

    public Image MusicButton;
    public Image SFXButton;

    private bool MusicOn = true;
    private bool SFXOn = true;



    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
        MusicOn = !MusicOn;
        if (MusicOn)
        {
            MusicButton.sprite = MusicOnSprite;
        }

        else
        {
            MusicButton.sprite = MusicOffSprite;
        }
        
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
        SFXOn = !SFXOn;
        if (SFXOn)
        {
            SFXButton.sprite = SFXOnSprite;
        }

        else
        {
            SFXButton.sprite = SFXOffSprite;
        }
    }
}
