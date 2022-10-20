using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreKeeping : MonoBehaviour
{
    public float player1Score;
    public float player2Score;

    public TextMeshProUGUI score1Text;
    public TextMeshProUGUI score2Text;

    public GameObject puckPrefab;
    public bool isDead = false;
    public float timeRemaining = 1f;

    public GameObject GameOver;
    public TextMeshProUGUI WinnerText;
    // Start is called before the first frame update
    void Start()
    {
        player1Score = 0f;
        player2Score = 0f;
        Instantiate(puckPrefab, new Vector2(1, 1), puckPrefab.transform.rotation);

        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score1Text.text = player1Score.ToString();
        score2Text.text = player2Score.ToString();
        
        //spawning for puck
        if(isDead == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Instantiate(puckPrefab, new Vector2(1, 1), puckPrefab.transform.rotation);
                isDead = false;
            }
            
        }
        if(isDead == false)
        {
            timeRemaining = 1f;
        }


        //check for game ending
        if(player1Score >= 5)
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
            WinnerText.text = "Player 2 Wins!!";

        }
        if(player2Score >= 5)
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
            WinnerText.text = "Player 2 Wins!!";
        }
    }
}
