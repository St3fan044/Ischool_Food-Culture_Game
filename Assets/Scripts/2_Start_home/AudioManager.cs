using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    public bool AudioOn = true;

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad (this.gameObject);
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode loadscenemode)
    {
        if (AudioOn)
        {
            FindObjectOfType<AudioSource>().mute = false;
        }

        else
        {
            FindObjectOfType<AudioSource>().mute = true;
        }
    }

    public void toggleaudio()
    {
        AudioOn = !AudioOn;

    }
}
