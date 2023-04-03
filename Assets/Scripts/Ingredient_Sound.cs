using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient_Sound : MonoBehaviour
{
    public AudioSource i_sound;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            i_sound.Play();
        }
    }
}
