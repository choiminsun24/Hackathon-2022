using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Ending : MonoBehaviour
{
    public GameObject Elephant, Dog, XButton, EndingPopup, EndButton, ReplayButton;

    public TextMeshProUGUI ShowScore;

    //점수 저장
    private GameObject S;
    Calculate Count;

    public void Start()
    {
        EndingPopup.SetActive(false);
        EndButton.SetActive(false);
        ReplayButton.SetActive(false);

        S = GameObject.FindGameObjectWithTag("Score");
        Count = S.GetComponent<Calculate>();

        Invoke("Write_Score", 1f);
    }

    public void Write_Score()
    {
        if (Count.getScore_int() < 50)
        {
            Elephant.SetActive(false);
            Dog.SetActive(false);
        }

        ShowScore.text = "당신의 점수는 " + Count.getScore() + "점 입니다.";
    }

    public void PressButton()
    {
        ShowScore.gameObject.SetActive(false);
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
