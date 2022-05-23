using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    // PLayer Rigidbody Movement
    public Player_Movement _playerMovement;
    public Player_Input _playerInput;
    public ScoreManager _scoreManager;
    public Transform _transform;
    void Start()
    {   _playerMovement = GetComponent<Player_Movement>();
        _playerInput = GetComponent<Player_Input>();
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
