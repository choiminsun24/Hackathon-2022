using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiTap : MonoBehaviour
{
    public GameObject Popup;
    public GameObject Btn1_1, Btn1_2, Btn2_1, Btn2_2, Btn3_1, Btn3_2, Btn4_1, Btn4_2, Btn5_1, Btn5_2, Btn6_1, Btn6_2, Btn7_1, Btn7_2;

    Calculate Count;

    public void Start()
    {
        Count = GetComponent<Calculate>();
        Popup.SetActive(false);
    }

    public void ClickOk()
    {
        Popup.SetActive(true);
        Count.AddScore(20);

        //if (Btn1_1 == null && Btn1_2 == null && Btn2_1 == null && Btn2_2 == null && Btn3_1 == null && Btn3_2 == null && Btn4_1 == null && Btn4_2 == null && 
        //  Btn5_1 == null && Btn5_2 == null && Btn6_1 == null && Btn6_2 == null Btn7_1 == null Btn7_2 == null)
        // 충전선 버튼 다 제거했으면 총점 ++!!!
    }
}
