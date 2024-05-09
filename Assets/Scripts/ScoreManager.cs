using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score;
    private void Awake()
    {
        instance = this;
    }
    public void AddScore()
    {
        score++;
        Debug.Log("He sumado puntos: " + score);
    }
}
