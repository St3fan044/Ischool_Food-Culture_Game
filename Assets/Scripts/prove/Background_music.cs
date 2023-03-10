using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Background_music : MonoBehaviour
{
    private static Background_music backgroundmusic;
    private void Awake()
    {
        if (backgroundmusic == null)
        {
            backgroundmusic = this;
            DontDestroyOnLoad(backgroundmusic);
        }
        else
        {
            Destroy(gameObject);
        } 
    }
}
