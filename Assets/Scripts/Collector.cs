using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "ingredienti" || target.tag == "malus")
        {
            Destroy(target.gameObject); 
        }
    }
}
