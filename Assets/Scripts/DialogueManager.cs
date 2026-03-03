using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public GameObject dialogueCanvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartDialogue(string dialogue)
    {
        dialogueCanvas.SetActive(true);
        dialogueCanvas.transform.GetChild(0).GetComponent<TMP_Text>().text = dialogue;
        
    }
}
