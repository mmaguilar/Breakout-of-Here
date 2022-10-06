using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text displayText;
    public TMP_Text gameOverText;
    public GameObject gameOverPanel;
    public TMP_Text gameOverPanelText;


    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        //displayText.text = "GOOOOO!!!";
        gameOverPanel.SetActive(false);

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
        StartCoroutine(gameOverSequence());
    }

    IEnumerator gameOverSequence(){
        gameOverPanel.SetActive(true);
        yield return new WaitForSeconds(3);
                SceneManager.LoadScene(0);

    }
}
