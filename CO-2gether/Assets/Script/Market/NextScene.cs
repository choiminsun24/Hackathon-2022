using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;
    public GameObject arrow;

    public void Start()
    {
        arrow.SetActive(true);
    }

    public void ClickBtn()
    {
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }

}
