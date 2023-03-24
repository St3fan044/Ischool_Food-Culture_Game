using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chage_scene : MonoBehaviour
{
    public void go_to_reward_scene()
    {
        SceneManager.LoadScene("5_Reward");
    }
}
