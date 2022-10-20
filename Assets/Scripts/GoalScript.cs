using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject scoreObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (gameObject.name == "Player1Goal")
        {
            scoreObject.GetComponent<ScoreKeeping>().player2Score++;
            Debug.Log(scoreObject.GetComponent<ScoreKeeping>().player2Score);
            scoreObject.GetComponent<ScoreKeeping>().isDead = true;
            Destroy(col.gameObject);
        }
        else
        {
            scoreObject.GetComponent<ScoreKeeping>().player1Score++;
            Debug.Log(scoreObject.GetComponent<ScoreKeeping>().player1Score);
            scoreObject.GetComponent<ScoreKeeping>().isDead = true;
            Destroy(col.gameObject);
        }

    }
}
