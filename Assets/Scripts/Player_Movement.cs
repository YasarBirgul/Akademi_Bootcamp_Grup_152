using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Player`s components
    private Animator _playerAnimator;

    private Transform _playerTransform;
    // Rigidbody Force rate 
    [SerializeField] public float forceRate;
   
   
    void Start() {
      
        _playerAnimator = GetComponent<Animator>();
        _playerTransform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        _playerTransform.transform.position =
            new Vector3(transform.position.x, transform.position.y, transform.position.z + forceRate);

        if (Input.touchCount != 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {    
                _playerAnimator.SetBool("jump_touch", true);
                Invoke("setBoolBack",1f);
            }
        }
        
    }
    
    public void setBoolBack()
             {
                 _playerAnimator.SetBool("jump_touch", false);
                 
             }
}
