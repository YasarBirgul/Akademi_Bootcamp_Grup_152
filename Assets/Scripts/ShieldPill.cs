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
    private PlayerParticleSystem _particle;
    [SerializeField]
    private ParticleSystem _particleSystemWhite;
    private void Awake()
    {
        _playerMovement=GetComponent<Player_Movement>();
        _materialSwapper=GetComponent<PlayerMaterialSwapper>();
        _particle = GetComponent<PlayerParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShieldPill"))
        {
            _playerMovement.movementSpeed = 750;
            Destroy(other.gameObject);
            _materialSwapper.changeMat(_materialSwapper.MaterialSpeed);
            _particle.ParticleState(_particleSystemWhite,true);
        }
        Invoke("BacktoNormal",7);
    }

    void BacktoNormal()
    { _playerMovement.movementSpeed = 500; 
        _materialSwapper.changeMat(_materialSwapper.MaterialNorm);
        _particle.ParticleState(_particleSystemWhite,false);
    }

}
