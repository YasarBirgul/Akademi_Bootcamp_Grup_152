using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
  public int playerHealth;

  [SerializeField] private Image[] hearths;

  public void Awake()
  {
    UpdateHealth();
  }

  public void Update()
  {
    

    if (playerHealth == 0)
    {

      SceneManager.LoadScene(2);
    }
    
  }

  public void UpdateHealth()
  {
    for (int i = 0;i< hearths.Length;i++)
    {
      if (i < playerHealth)
      {

        hearths[i].color = Color.red;
      }
      else
      {
        hearths[i].color = Color.clear;
      }
      
    }
  }
}
