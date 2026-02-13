using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chips : MonoBehaviour
{
    public GameObject light;
    public GameObject chipsOpen;
    bool canInteract = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        light.SetActive(true);
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        light.SetActive(false);
        canInteract = false;
    }

    private void OnMouseDown()
    {
        if (canInteract)
        {
            chipsOpen.SetActive(true);
        }
        
    }
}
