using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    public static Calculate instance;

    public int Score;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public string getScore()
    {
        return Score.ToString();
    }
}
