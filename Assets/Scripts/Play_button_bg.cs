using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class Play_button_bg : MonoBehaviour
    {
        public void play()
        {
            SceneManager.LoadScene("2_Start_home");
        }

    }
