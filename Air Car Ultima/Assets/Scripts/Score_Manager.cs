using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public static Score_Manager instance;
    public Text scoreText;
    public Text highscoreText;
    int score = 0;
    int highscore = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}