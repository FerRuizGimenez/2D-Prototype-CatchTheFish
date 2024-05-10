using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{   
    public static LivesManager instance;
    private int livesCounter = 5;
    private GameObject[] livesImageUI;
    private Color uIImageColor;
    private void Awake()
    {
        instance = this;
        livesImageUI = GameObject.FindGameObjectsWithTag("LifeImageUI");
        uIImageColor = new Color(1, 1, 1, 0.5f);
    }
    public void RemoveLife()
    {
        if(livesCounter > 0)
        {
            livesCounter--;
            SetLivesImagesUI();
        }
        if(livesCounter <= 0)
        {
            GameManager.instance.GameOver();
        } 
    }

    private void SetLivesImagesUI()
    {
        livesImageUI[livesCounter].GetComponent<Image>().color = uIImageColor;    
    }
}
