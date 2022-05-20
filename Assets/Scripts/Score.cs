using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score og2d { get; private set; }
    public static int score { get; private set; }
    public  int highScore;
    private void Awake()
    {
        og2d = this;
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore1", 0);
    }
    private void Update()
    {
        UpdateDisplay();
        CheckHighScore();
    }

    public Text scoreText;
    public Text highScoreText;
    public void ScoreIncrease(float tranform_float_z)
    {
         if ((int)tranform_float_z > score)
               {    int a = (int)tranform_float_z;
                    score = a;
                    Debug.Log(score);
               }
    }
    public void UpdateDisplay()
    {
        scoreText.text = "Score : " + score;
        highScoreText.text = "High Score :" + highScore;
    }

    public void CheckHighScore()
    {
        if(score > highScore)
        
       PlayerPrefs.SetInt("Highscore1",score);
        
    }
    
    

}
