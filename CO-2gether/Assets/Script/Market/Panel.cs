using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;
    public GameObject arrow;
    public GameObject right;
    public GameObject fail;

    public GameObject score;

    Calculate c;

    void Start()
    {
        c = score.GetComponent<Calculate>();

        arrow.SetActive(false);
        right.SetActive(false);
        fail.SetActive(false);
    }

    // Update is called once per frame
    public void ClickBtn()
    {
        
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }

    public void RightBtn()
    {
        c.AddScore(5);
        right.SetActive(true);
        arrow.SetActive(true);
    }

    public void FailBtn()
    {
        fail.SetActive(true);
        arrow.SetActive(true);
    }

}
