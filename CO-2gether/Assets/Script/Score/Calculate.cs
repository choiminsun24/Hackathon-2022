using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    public static Calculate instance;

    private int Score;
    DataManager DM;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        DM = gameObject.AddComponent<DataManager>();
    }

    public string getScore()
    {
        return Score.ToString();
    }

    public int getScore_int()
    {
        return Score;
    }

    public void setScore(int score)
    {
        Score = score;
    }

    public void AddScore(int score)
    {
        Score += score;
        DM.JsonSave();
    }

    public void reset_Score()
    {
        Score = 0;
        DM.JsonSave();
    } 
}
