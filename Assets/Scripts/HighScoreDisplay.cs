using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    Text highScore;
    GameSession gameSession;

    // Start is called before the first frame update
    void Start()
    {
        highScore = GetComponent<Text>();
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameSession.GetScore() > PlayerPrefs.GetInt("HighScore", 0))
        { 
            PlayerPrefs.SetInt("HighScore", gameSession.GetScore());
            highScore.text = gameSession.GetScore().ToString();
            PlayerPrefs.Save();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll(); // deletes all saved records
        highScore.text = "0";
    }
}
