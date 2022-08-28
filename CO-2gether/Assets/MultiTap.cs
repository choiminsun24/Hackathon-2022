using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiTap : MonoBehaviour
{
    public GameObject Popup;

    public void Start()
    {
        Popup.SetActive(false);
    }

    public void ClickOk()
    {
        Popup.SetActive(true);
    }
}
