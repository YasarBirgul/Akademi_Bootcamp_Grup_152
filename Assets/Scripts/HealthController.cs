using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.Ad.Example;
public class HealthController : MonoBehaviour
{
  public int playerHealth;
  private bool forceRateDesrease;
  [SerializeField] private Image[] hearths;
  private PlayerMovement _playerMovement;
  public ShowAdvertisement _showAdvertisement;
  
  public void Awake()
  {
    _playerMovement = GetComponent<PlayerMovement>();
    playerHealth = hearths.Length;
    UpdateHealth();
  }
  public void Update()
  {
    if (playerHealth == 0)
    {
      _showAdvertisement.myFunction();
      ScoreManager.OG2D.CheckHighScore();
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
  public void OnCollisionEnter(Collision other)
  { 
    if (other.gameObject.CompareTag("OBS") && forceRateDesrease == false)
    {
      playerHealth -= 1;
      UpdateHealth();
      forceRateDesreaseHalf();
      Invoke("forceRateBackToNormal",3f);
      Destroy(other.gameObject); // Can be changed 
    }
  } 
  void forceRateDesreaseHalf()
  {
    _playerMovement.movementSpeed = _playerMovement.movementSpeed  / 2;
    forceRateDesrease = true;

  }
  void forceRateBackToNormal()
  {
    _playerMovement.movementSpeed = _playerMovement.movementSpeed * 2;
    forceRateDesrease = false;
  }
  
  
  
}
