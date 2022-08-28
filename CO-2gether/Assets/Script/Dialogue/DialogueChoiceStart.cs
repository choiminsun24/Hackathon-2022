using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueChoiceStart : MonoBehaviour
{
    public Dialogue dia;
    public TextMeshProUGUI Text;
    private GameObject Score;

    public GameObject ChoiceBox;

    void Start()
    {

    }

    public void Trigger()
    {
        ChoiceBox.SetActive(false);
        FindObjectOfType<DialogueManager>().StartDialogue(dia);
    }
}
