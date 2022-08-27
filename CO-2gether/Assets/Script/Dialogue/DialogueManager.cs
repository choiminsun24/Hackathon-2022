using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Queue<string> sentences;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue) //대화 시작
    {
        sentences.Clear(); //이전 대화 삭제

        nameText.text = dialogue.name; //화자

        foreach (string sentence in dialogue.sentences) //큐의 문장을 한 문장씩 넣어줌.
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence(); //sentences에 담긴 문장을 한 글자씩 출력
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char c in sentence.ToCharArray())
        {
            dialogueText.text += c;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        FindObjectOfType<Fade>().Move_Scene("Start");//AirConditional
    }


    // Update is called once per frame
    void Update()
    {

    }
}
