using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handel : MonoBehaviour
{
    public Transform target;
    
    private void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        Vector3 cursorPos = (mouseRay.origin + mouseRay.direction);
        Vector3 relPos = new Vector3(cursorPos.x, cursorPos.y,cursorPos.z);
        //Debug.Log(Input.mousePosition);
        
        if (Input.anyKeyDown)
        {
            target.position = cursorPos;
            Debug.Log("kursor: " + cursorPos);
            Debug.Log("Dzwignia" + transform.position);
        }
        
        relPos = new Vector3(relPos.x, relPos.y, 0);
        transform.rotation = Quaternion.LookRotation(relPos,new Vector3(0,0,0));
    }
}
