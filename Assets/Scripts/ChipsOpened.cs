using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipsOpened : MonoBehaviour
{
    public GameObject dialogueCanvas;

    private void OnMouseDown()
    {
        dialogueCanvas.SetActive(false);
        gameObject.SetActive(false);
    }
}
