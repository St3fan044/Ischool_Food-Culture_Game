using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public UnityEvent on_full_bar;
    public float slidermax;

     public void UpdateSlider(float value)
     {
        slider.value += value;
        if(slider.value == slidermax)
        {
            on_full_bar?.Invoke();
        }
     }   
}
