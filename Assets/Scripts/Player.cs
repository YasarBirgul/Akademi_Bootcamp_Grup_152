using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    // PLayer Rigidbody Movement
    [SerializeField]
    private Player_Movement _playerMovement;
    [SerializeField]
    private Player_Input _playerInput;
    [SerializeField]
    private ScoreManager _scoreManager;
    [SerializeField]
    private Transform _transform;
    void Awake()
    {   _playerMovement = GetComponent<Player_Movement>();
        _playerInput = GetComponent<Player_Input>();
        _scoreManager = GetComponent<ScoreManager>();
        _transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    public void Update()
    {  
        ScoreManager._instance.ScoreIncrease(_transform.position.z);
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
