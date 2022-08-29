using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject[] lifes;
    public GameObject backGround;

    public int playerLife = 3;
    public void Init(int playerLife)
    {
        for (int i = 0; i < playerLife; i++)
            this.lifes[i].SetActive(true);
    }

    public void damage()
    {
        playerLife -= 1;
        lifes[playerLife].SetActive(false);
        if (playerLife == 0)
        {
            backGround.SetActive(true);
            playerLife += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.backGround.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}