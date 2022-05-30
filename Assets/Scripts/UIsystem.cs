using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class UIsystem : MonoBehaviour
{
    public static UIsystem instaceUI;

    private void Awake()
    {
        if (instaceUI == null)
        {
            instaceUI = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnGUI()
    {   
        GUIStyle secondStyle = new GUIStyle();
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 80;
        myStyle.normal.textColor = Color.white;
        secondStyle.fontSize = 20;
        secondStyle.normal.textColor =Color.white;
        GUI.Label(new Rect(50f,50f,100f,200f),"" + ScoreManager._instance.score,myStyle);
        GUI.Label(new Rect(50f,150f,100f,200f), "Highest " + ScoreManager._instance.highScore,secondStyle);

    }
}
