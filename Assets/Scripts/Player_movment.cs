using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movment : MonoBehaviour
{
    public float movementspeed = 6;
    public float maxX = 6;

    void Start()
    {
        
    }

    void Update()
    {
        float movementhorizontal = Input.GetAxis("Horizontal");
        Vector2 spaceshipposition = transform.position;

        float v = spaceshipposition.x + (movementhorizontal * movementspeed * Time.deltaTime);
        spaceshipposition.x = Mathf.Clamp(v, -maxX, maxX);

        transform.position = (Vector3)spaceshipposition;
    }
}
