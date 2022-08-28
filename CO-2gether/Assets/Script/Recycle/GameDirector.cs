using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject[] lifes;
    public int i = 1;
    public void Init(int playerLife)
    {
        for (int i = 0; i < playerLife; i++)
            this.lifes[i].SetActive(true);
    }

    public void damage(int playerLife)
    {
        if(i == 2)
            playerLife = 2;
        if(i == 3)
            playerLife = 1;
        if (i == 0)
            playerLife = 0;
        playerLife -= 1;
        i++;
        lifes[playerLife].SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}