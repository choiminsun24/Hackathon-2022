using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueChoiceStart : MonoBehaviour
{
    public Dialogue dia;
    public GameObject Next;
    public GameObject ChoiceBox;

    void Start()
    {
        Next.SetActive(false);
    }

    public void Trigger()
    {
        ChoiceBox.SetActive(false);
        Next.SetActive(true);
        FindObjectOfType<DialogueManager>().StartDialogue(dia);
    }
}
