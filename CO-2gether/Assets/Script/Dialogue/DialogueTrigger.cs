using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dia;
    public TextMeshProUGUI Text;
    public GameObject Score;
    Score S;

    public void Trigger()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dia);
        Text.text = "Á¡¼ö: " + S.GetScore();
    }

    void Start()
    {
        S = Score.GetComponent<Score>();

        Invoke("Trigger", 1f);
    }
}
