using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{    
    // PLayer Rigidbody Movement
    public PlayerMovement _playerMovement;
    public PlayerInput _playerInput;
    public ScoreManager _scoreManager;
    public Transform _transform;
    void Start()
    {   _playerMovement = GetComponent<PlayerMovement>();
        _playerInput = GetComponent<PlayerInput>();
        _scoreManager = GetComponent<ScoreManager>();
        _transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    public void Update()
    {  
        ScoreManager.OG2D.ScoreIncrease(_transform.position.z);
        _playerInput.Jump();
    } 
    private void FixedUpdate()
    { 
        RigidBodyMovePlayer();
    }
    private void RigidBodyMovePlayer()
    {    
        _playerMovement.MovePlayer();
    }

}
