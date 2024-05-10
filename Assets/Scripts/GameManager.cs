using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private bool isGameOver = false;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        FishSpawner.instance.GetFishes();
        FishSpawner.instance.StartSpawnFisher();
        GameObject.Find("Player").GetComponent<PlayerController>().IsMoving = true;
    }
    public void GameOver()
    {
        FishSpawner.instance.StopSpawnFisher();
        GameObject.Find("Player").GetComponent<PlayerController>().IsMoving = false;
    }
}
