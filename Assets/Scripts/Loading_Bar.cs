using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class Loading_Bar : MonoBehaviour
{
    public GameObject bar;
    public int time;

    void Start()
    {
        Animate_Bar();
    }

    void Update()
    {
        if(time == 5)
        {
            //SceneManager.LoadScene("2_Start_home");
        }
    }

    public void Animate_Bar()
    {
        LeanTween.scaleX(bar, 1, time);
    }
}
