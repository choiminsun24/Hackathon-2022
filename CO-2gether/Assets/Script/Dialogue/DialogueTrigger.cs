using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dia;
    public TextMeshProUGUI Text;
    private GameObject Score;
    Calculate S;

    public void Trigger()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dia);
        Text.text = "Á¡¼ö: " + S.getScore();
    }

    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Score");
        S = Score.GetComponent<Calculate>();

        Invoke("Trigger", 1f);
    }
}
