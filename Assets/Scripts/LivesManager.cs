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
    private GameObject livesPanel;
    private void Awake()
    {
        instance = this;
        //livesImageUI = GameObject.FindGameObjectsWithTag("LifeImageUI");
        uIImageColor = new Color(1, 1, 1, 0.5f);
    }
    private void Start()
    {
        livesPanel = GameObject.Find("LivesPanel");
        livesImageUI = new GameObject[livesPanel.transform.childCount];
        for (int i = 0; i < livesPanel.transform.childCount; i++)
        {
            livesImageUI[i] = GameObject.Find("Life" + (i + 1));
        } 
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
