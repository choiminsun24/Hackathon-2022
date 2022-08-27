using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score = 0;

    public int AddScore(int A)
    {
        score += A;
        return score;
    }

    public int MinScore(int M)
    {
        score -= M;
        return score;
    }

    public string GetScore()
    {
        return score.ToString();
    }
}
