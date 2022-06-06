using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{   
    // Move Vector Player
    private Vector3 PlayerMoveVector3 = Vector3.forward;
    // Player MoveSpeed;
    public float movementSpeed;
    public void Init(Rigidbody _rbPlayer)
    {
        _rbPlayer = GetComponent<Rigidbody>();
    } 
    public void MovePlayer(Rigidbody _rbPlayer)
    { 
        _rbPlayer.velocity = PlayerMoveVector3 * movementSpeed*Time.deltaTime;
    }
}
