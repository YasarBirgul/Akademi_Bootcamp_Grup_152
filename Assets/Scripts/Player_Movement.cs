using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Player`s components
    private Rigidbody theplayer;
    private Animator _playerAnimator;
    
    // Rigidbody Force rate 
    [SerializeField] public float forceRate;
   
   
    void Start() {
        theplayer = GetComponent<Rigidbody>();
        _playerAnimator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x ,transform.position.y,transform.position.z+forceRate);
        
       if (Input.touchCount != 0)
                    {
                        if (Input.GetTouch(0).phase == TouchPhase.Began)
                        {
                            _playerAnimator.SetBool("jump_touch", true);
                          //  theplayer.transform.position = new Vector3(theplayer.transform.position.x, theplayer.transform.position.y+1, theplayer.transform.position.z);
                        }
                    }
    }
    
    // Players Rigidbody Force for the main movement...
  //  private void FixedUpdate()
  //  {   theplayer.AddForce(transform.forward*forceRate);
  //      
  //      
  //             
  //      
  //      
  //     
  //  }
    
}
