using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Change_animation2 : MonoBehaviour
{
    public void LoadNewScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("2_Start_home");
    }
}
