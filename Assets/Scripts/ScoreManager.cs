using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager _instance;
    public int score;
    public int highScore;
    
    void Start()
    {
        if (_instance == null)
        { _instance = this; score = 0; 
            highScore = PlayerPrefs.GetInt("HighScore1", 0);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
          Destroy(gameObject);    
        }
    }

    private void OnGUI()
    {   GUIStyle secondStyle = new GUIStyle();
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 80;
        myStyle.normal.textColor = Color.white;
        secondStyle.fontSize = 20;
        secondStyle.normal.textColor =Color.white;
        GUI.Label(new Rect(50f,50f,100f,200f),"" + score,myStyle);
        GUI.Label(new Rect(50f,150f,100f,200f), "Highest " + highScore,secondStyle);
        
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
           Debug.Log(score);
       }
   }
    
    
    
}
