using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShieldPill : MonoBehaviour
{
    [SerializeField]
    private Player_Movement _playerMovement;
    [SerializeField]
    private PlayerMaterialSwapper _materialSwapper;
    
    private void Awake()
    {
        _playerMovement=GetComponent<Player_Movement>();
        _materialSwapper=GetComponent<PlayerMaterialSwapper>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShieldPill"))
        {
            _playerMovement.movementSpeed = 750;
            Destroy(other.gameObject);
            _materialSwapper.changeMat(_materialSwapper.Material1);
        }
        Invoke("BacktoNormal",7);
    }

    void BacktoNormal()
    { _playerMovement.movementSpeed = 500; 
        _materialSwapper.changeMat(_materialSwapper.MaterialNorm);
    }

}
