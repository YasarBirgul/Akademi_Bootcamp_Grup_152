using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    // MOVEMENT VALUES
    private Vector3 playerMoveVector = Vector3.forward;
    public float movementSpeed;
    // Rigidbody of the Player
    private Rigidbody rbPlayer;
    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }
    public void MovePlayer()
    { 
        rbPlayer.velocity = playerMoveVector * movementSpeed*Time.deltaTime;
    }
}
