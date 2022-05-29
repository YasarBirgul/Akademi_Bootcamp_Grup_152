using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{   private Vector3 PlayerMoveVector3 = Vector3.forward;
    public float movementSpeed;
    private Rigidbody _rbPlayer;
    void Start()
    {
        _rbPlayer = GetComponent<Rigidbody>();
    } 
    public void MovePlayer()
    { 
        _rbPlayer.velocity = PlayerMoveVector3 * movementSpeed * Time.deltaTime;
    }
}
