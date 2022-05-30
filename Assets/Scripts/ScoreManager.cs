using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager _instance;
    public int score;
    public int highScore;
    
    void Awake()
    {
        if (_instance == null)
        {   _instance = this;
            score = 0; 
            highScore = PlayerPrefs.GetInt("HighScore1", 0);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);    
        }
    }
    public void CheckHighScore()
    { 
        if (score > highScore)
        {
            Debug.Log("Saving Score");
            PlayerPrefs.SetInt("HighScore1",score);
        }
    }
    public void ScoreIncrease(float tranform_float_z)
   {
       if ((int)tranform_float_z > score)
       {    int a = (int)tranform_float_z;
           score = a;
       }
   }
    public void ResetScore()
    { 
        score = 0;
    }
}
