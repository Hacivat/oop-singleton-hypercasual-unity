using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance { get; private set; }

    private int score;
    private void Awake()
    {
        Instance = this;
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int scoreValue)
    {
        score += scoreValue;
    }
}
