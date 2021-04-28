using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class MyGameManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public int playerHealth = 3;
    public TMP_Text playerHealthText;
    bool gameHasEnded = false;
    public GameObject reviveMenuUI;
    public GameObject lostTextUI;
    public GameObject winTextUI;

    public static MyGameManager instance = null;

    
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1f;


    }
 
    void Update()
    {
        

        if(playerHealth <= 0)
        {
            reviveMenuUI.SetActive(true);
            lostTextUI.SetActive(true);
            winTextUI.SetActive(false);
            Time.timeScale = 0f;

        }
        else if(score >= 50)
        {
            reviveMenuUI.SetActive(true);
            winTextUI.SetActive(true);
            lostTextUI.SetActive(false);
            Time.timeScale = 0f;
        }

    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Restart();
        }
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    
}

