using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score_ReplayScene : MonoBehaviour
{   
    private void OnGUI()
    {   GUIStyle firstStyle = new GUIStyle();
        GUIStyle secondStyle = new GUIStyle();
        secondStyle.fontSize = 100;
        firstStyle.fontSize = 50;
        secondStyle.normal.textColor = Color.black;
        firstStyle.normal.textColor= Color.black;
        GUI.Label(new Rect(300f,275f,100f,200f),"Score : " + ScoreManager.OG2D.score,secondStyle);
        GUI.Label(new Rect(300f,450f,100f,200f),"Highest Score : " + ScoreManager.OG2D.highScore,firstStyle);
    }
}
