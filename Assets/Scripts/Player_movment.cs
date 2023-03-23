using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movment : MonoBehaviour
{
    Vector2 difference = Vector2.zero;

    private void OnMouseDrag()
    {
        Vector2 mousepos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
        float xpos = Mathf.Clamp(mousepos.x, -1.85f, 1.85f);
        transform.position = new Vector2(xpos, transform.position.y);
    }
}
