using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{ public int playerHealth;
    private bool forceRateDesrease;
    [SerializeField] private Image[] hearths;
    private Player_Movement _playerMovement;
    // public ShowAdvertisement _showAdvertisement;
    private PlayerMaterialSwapper _materialSwapper;
    public void Awake()
    {
        _playerMovement = GetComponent<Player_Movement>();
        playerHealth = hearths.Length;
     //   _showAdvertisement = GetComponent<ShowAdvertisement>();
        UpdateHealth();
        _materialSwapper = GetComponent<PlayerMaterialSwapper>();
    }
    public void Update()
    {
        if (playerHealth == 0)
        {
          //  _showAdvertisement.myFunction();
            ScoreManager._instance.CheckHighScore();
            SceneManager.LoadScene(2);
        }
   
    }
    public void UpdateHealth()
    {
        for (int i = 0;i< hearths.Length;i++)
        {
            if (i < playerHealth)
            {

                hearths[i].color = Color.yellow;
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
            Invoke("forceRateBackToNormal",6f);
            Destroy(other.gameObject); // Can be changed 
           
        }
    } 
    void forceRateDesreaseHalf()
    {
        _playerMovement.movementSpeed = _playerMovement.movementSpeed  / 2;
        forceRateDesrease = true;
        _materialSwapper.changeMat(_materialSwapper.materialDamage);
    }
    void forceRateBackToNormal()
    {
        _playerMovement.movementSpeed = _playerMovement.movementSpeed * 2;
        forceRateDesrease = false;
        _materialSwapper.changeMat(_materialSwapper.MaterialNorm);
    }
    
}
