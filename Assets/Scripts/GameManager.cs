using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        //displayText.text = "GOOOOO!!!";
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = playerScore.ToString();
        
    }

    public void AddPoints(int points){
        playerScore += points;
    }

    public void GameOver()
    {
        //Debug.Log("Game Over!!");
        SceneManager.LoadScene(0);
    }
}
