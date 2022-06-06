using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    // PLayer Rigidbody Movement
    [SerializeField]
    private Player_Movement _playerMovement;
    [SerializeField]
    private Transform _transform;
    [SerializeField]
    private Rigidbody _rbPlayer;
    void Awake()
    {   _playerMovement = GetComponent<Player_Movement>();
        _transform = GetComponent<Transform>();
        _playerMovement.Init(_rbPlayer);
    }
    public void Update()
    {   //Calculating the score based on runners position z 
        ScoreManager._instance.ScoreIncrease(_transform.position.z);
    } 
    private void FixedUpdate()
    {   
        //Player Running Forward Movement
        _playerMovement.MovePlayer(_rbPlayer);
    }
}
