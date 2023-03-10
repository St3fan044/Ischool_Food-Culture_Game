using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;

     public void UpdateSlider(float value)
     {
        slider.value += value;
     }   
}
