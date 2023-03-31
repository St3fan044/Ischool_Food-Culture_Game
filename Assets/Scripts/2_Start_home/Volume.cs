using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;


    public AudioClip AudioClipClickButton;
    public AudioClip AudioBarraCompletamento;
    public AudioClip AudioBusta;



    public AudioSource audioSource;

    private void Start()
    {
       soundOnImage = button.image.sprite; 
    }

    private void Update()
    {
        
    }
    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
           audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }


    


}
