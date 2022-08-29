using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{
    public Text waterTxt;
    public Text lifeTxt;
    public Text needWaterTxt;
    public GameObject stageStartTxt;
    public GameObject stageClearTxt;
    public GameObject stageFailTxt;
    public GameObject gameClearPanel;
    public GameObject gameOverPanel;
    public GameObject waterSize;
    public GameObject clickBtn;
    public GameObject removeBox;
    public GameObject plant;
    public Sprite plantComplete;
    public Vector3 objectScale;

    public bool isPlaying;
    public int water;
    public int waterHeight;
    public int clearCnt;
    public int gameClearScore;
   
    private int life;

    void Start()
    {
        life = 3;
        StartCoroutine(StageStart());
    }


    IEnumerator StageStart()
    {
        yield return new WaitForSeconds(1f);
        waterTxt.text = "water: 0";
        water = Random.Range(4, 9);
        needWaterTxt.text = water.ToString();
        stageStartTxt.SetActive(true);
        yield return new WaitForSeconds(1f);
        stageStartTxt.SetActive(false);
        isPlaying = true;
    }

    IEnumerator Stage(GameObject text)
    {
        waterSize.transform.localScale = new Vector3((float)0.8, 0, objectScale.z);
        isPlaying = false;
        lifeTxt.text = life.ToString();
        removeBox.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        text.SetActive(true);
        yield return new WaitForSeconds(1f);
        text.SetActive(false);
        removeBox.SetActive(false);
        StartCoroutine(StageStart());
    }

    private void LateUpdate() 
    {

        if ((int)(waterSize.transform.localScale.y * 10) <= water + 1)
        {
            waterTxt.text = "water: " + ((int)(waterSize.transform.localScale.y * 10)).ToString();
        }
        else
        {
            life--;
            if (life > 0)
            {
                StartCoroutine(Stage(stageFailTxt));
            }
            else 
            {
                Game(gameOverPanel);
            }
        }
    }

    public void ClickButton()
    {
        if (water == (int)(waterSize.transform.localScale.y * 10))
        {
            clearCnt += 1;
            if (clearCnt == 4)
            {
                plant.GetComponent<SpriteRenderer>().sprite = plantComplete;
                plant.transform.localScale = new Vector3((float)0.6, (float)0.6, (float)0.6);
                Game(gameClearPanel);
                gameClearScore += 20;
            }
            else 
            {
                StartCoroutine(Stage(stageClearTxt));
            }
        }
        else
        {
            life--;
            if (life > 0)
            {
                StartCoroutine(Stage(stageFailTxt));
            }
            else
            {
                Game(gameOverPanel);
            }
        }
    
    }

    public void Game(GameObject panel)
    {
        isPlaying = false;
        panel.SetActive(true);
        removeBox.SetActive(true);
        waterTxt.text = "water: 0";
        lifeTxt.text = life.ToString();
        waterSize.transform.localScale = new Vector3(objectScale.x, 0, objectScale.z);
    }

}
