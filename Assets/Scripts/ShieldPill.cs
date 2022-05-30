using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShieldPill : MonoBehaviour
{
    [SerializeField]
    private Player_Movement _playerMovement;

    private void Awake()
    {
        GetComponent<Player_Movement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShieldPill"))
        {
            _playerMovement.movementSpeed = 750;
            Destroy(other.gameObject);
        }
        Invoke("BacktoNormal",7);
    }

    void BacktoNormal()
    { _playerMovement.movementSpeed = 500;
        
    }

}
