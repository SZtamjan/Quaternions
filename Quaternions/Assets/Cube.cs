using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void Update()
    {
        //transform.Translate(0,0,-Input.GetAxis("Horizontal")*3f*Time.deltaTime);
        transform.Translate(new Vector3(0,0,1*Time.deltaTime));
    }
}
