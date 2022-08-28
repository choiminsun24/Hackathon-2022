using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Control : MonoBehaviour
{
    public TMP_Text Result;
    public GameObject Message;
    private int temperature; 

    public void Start()
    {
        Message.SetActive(false);
        temperature = Random.Range(1, 100);
        Result = GetComponent<TMP_Text>();
        Result.text = "온도: " + temperature.ToString() + "°C";
    }

    public void ClickUp()
    {
        temperature += 1;
        Result.text = "온도: " + temperature.ToString() + "°C";
    }

    public void ClickDown()
    {
        temperature -= 1;
        Result.text = "온도: " + temperature.ToString() + "°C";
    }

    public void Ok()
    {
        Message.SetActive(true);
    }
}
