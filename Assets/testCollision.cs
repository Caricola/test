using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class testCollision : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       Debug.Log("Enter");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit");
    }
}
