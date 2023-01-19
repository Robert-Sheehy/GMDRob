using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    Vector3 acceleration, velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // acceleration = 9.8f * Vector3.down;            // F = ma




        velocity += acceleration * Time.deltaTime;      // v = u + at
        transform.position += velocity* Time.deltaTime; // s = ut
    }

    internal void changeColor(Color newColor)
    {
        GetComponent<Renderer>().material.color = newColor;
    }
}
