using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Ending : MonoBehaviour
{
    public GameObject Elephant, Dog, XButton, EndingPopup, EndButton, ReplayButton;
    public GameObject Scorebag;

    private TMP_Text ShowScore;

    public GameObject S;
    Calculate Count;
    public int score;    // ���� �� ���� ���� score�� ����!!!

    public void Start()
    {
        Count = S.GetComponent<Calculate>();
        EndingPopup.SetActive(false);
        EndButton.SetActive(false);
        ReplayButton.SetActive(false);

        score = Count.Score;
        Debug.Log(score);

        if (score < 50)
        {
            Elephant.SetActive(false);
            Dog.SetActive(false);
        }

        ShowScore = Scorebag.GetComponent<TMP_Text>();
        ShowScore.text = "����� ������ " + Count.getScore() + "���Դϴ�.";
    }

    public void PressButton()
    {
        Scorebag.SetActive(false);
        XButton.SetActive(false);

        EndingPopup.SetActive(true);
        EndButton.SetActive(true);
        ReplayButton.SetActive(true);
    }

    public void ClickEnd()
    {
#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying=false;
#elif UNITY_WEBPLAYER
Application.OpenURL("https://ash-dolphin-053.notion.site/SMSWH-28-ce2e5513573841ef9fbf233806e22310");
#else
        Application.Quit();
#endif
    }

    public void ClickReplay()
    {
        SceneManager.LoadScene(0);
    }
}
